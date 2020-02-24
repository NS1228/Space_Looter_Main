using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class Nil_FOVdetection : MonoBehaviour
{
    //objects
    [HeaderAttribute("Objects")]
    public NavMeshAgent agent;
    public GameObject player;
    public GameObject soundLocation;
    private GameObject moveToLocation;
    public Transform Player;

    //waypoint stuff
    [HeaderAttribute("Waypoints")]
    public GameObject[] waypoints;
    private int num = 0;
    private float minDist;
    private bool rand = true;
    private bool go = true;


    //speed variables
    [HeaderAttribute("Speed")]
    public float patrolSpeed;
    public float invSoundSpeed;
    public float chaseSpeed;
    private float stopSpeed;
    public float slowedPatrol;
    public float slowedInvSound;
    public float slowedChase;


    // private float speed;

    //FOVstuff
    [HeaderAttribute("Sight Detection")]
    public float defaultRadius;
    public float chaseRadius;
    public float defaultAngle;
    public float chaseAngle;
    private float maxAngle;
    private float maxRadius;

    //Finite state machine
    public enum State
    {
        PATROL,
        CHASE,
        SEARCH,
        INVESTIGATE


    }

    [HeaderAttribute("AI State Variables")]
    //variables fo state machine
    private float waitTime;
    private float investigateTime;
    private bool reInvestigate;
    private float reInvestigateTimer;
    private bool investigating;
    private float chaseTimer;
    private bool chase;
    private bool soundDetected;
    private float soundInvestigateTimer;
    private bool destroyMoveTo;
    private float moveToDestroyTimer;
    private bool notChasing;
    private bool notInvestigating;
    public State state;
    private bool alive;
    public float timeSinceLastSeen;
    private bool isinFov = false;

    //Gadget stuff
    public static bool flashLightBlindingLight;
   

    // NOT USED
    private Vector3 smoothVelocity = Vector3.zero;
    private float thrust = 1.0f;
    private Rigidbody rb;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, maxRadius);

        Vector3 fovLine1 = Quaternion.AngleAxis(maxAngle, transform.up) * transform.forward * maxRadius;
        Vector3 fovLine2 = Quaternion.AngleAxis(-maxAngle, transform.up) * transform.forward * maxRadius;

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, fovLine1);
        Gizmos.DrawRay(transform.position, fovLine2);

        if (!isinFov)
          Gizmos.color = Color.red;
           

        else
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, (Player.position - transform.position).normalized * maxRadius);
           

        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, transform.forward * maxRadius);
    }

    public static bool inFOV(Transform checkingObject, Transform target, float maxAngle, float maxRadius)
    {
        Collider[] overlaps = new Collider[10];
        int count = Physics.OverlapSphereNonAlloc(checkingObject.position, maxRadius, overlaps);

        for (int i = 0; i < count; i++)
        {
            if (overlaps[i] != null)
            {
                if (overlaps[i].transform == target)
                {
                    Vector3 directionBetween = (target.position - checkingObject.position).normalized;
                    directionBetween.y *= 0;

                    float angle = Vector3.Angle(checkingObject.forward, directionBetween);

                    if (angle <= maxAngle)
                    {
                        Ray ray = new Ray(checkingObject.position, target.position - checkingObject.position);
                        RaycastHit hit;

                        if (Physics.Raycast(ray, out hit, maxRadius))
                        {
                            if (hit.transform == target)
                                return true;
                        }
                    }

                }
            }
        }


        return false;
    }

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        state = Nil_FOVdetection.State.PATROL;
        alive = true;
        investigating = true;
        reInvestigate = false;
        notInvestigating = true;
        StartCoroutine("FSM");
        notChasing = true;
        soundDetected = false;
        rb = GetComponent<Rigidbody>();
        num = 1;
        minDist = 1;
        stopSpeed = 0;


    }

    // Update is called once per frame
    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.


        //checks if in fov (bool)
        isinFov = inFOV(transform, Player, maxAngle, maxRadius);
        
        if (isinFov)
        {
          
            notChasing = false;
            notInvestigating = true;
           // print("inFOV");

        }
        else if (!isinFov)
        {
           // print("NOTinFOV");
            if (Time.timeSinceLevelLoad >= timeSinceLastSeen)
            {
                notChasing = true;
                notInvestigating = true;
                soundDetected = false;
            }
            else
            {
                RunInvestigating();
                notInvestigating = false;
                
            }
       }

        if(soundDetected && notChasing)
        {
            RunInvestigating();
            notInvestigating = false;
        }
      

        if (notChasing && !soundDetected)
        {
            RunPatrol();
            maxRadius = defaultRadius;
            maxAngle = defaultAngle;
        }
        else
        {
            if (notInvestigating && !notChasing)
            {
                RunChase();
                maxRadius = chaseRadius;
                maxAngle = chaseAngle;
            }
        }

        //print(Time.timeSinceLevelLoad);

       /* if(Input.GetKey(KeyCode.L))
        {
            flashLightBlindingLight = true;
        }
        if (Input.GetKey(KeyCode.M))
        {
            flashLightBlindingLight = false;
        } */


        
      
    }

    IEnumerator FSM()
    {
        while (alive)
        {
            switch (state)
            {
                case State.PATROL:
                    Patrol();
                    break;
                case State.CHASE:
                    Chase();
                    break;
                case State.INVESTIGATE:
                    Investigate();
                    break;

            }
            yield return null;

        }


    }

    void RunPatrol()
    {

        float dist = Vector3.Distance(gameObject.transform.position, waypoints[num].transform.position);

        if (go)
        {
            if (dist > minDist)
            {
                
                    state = Nil_FOVdetection.State.PATROL;
                
               
            }
            else
            {
                if (Time.timeSinceLevelLoad >= waitTime)
                {


                    if (!rand)
                    {
                        if (num + 1 == waypoints.Length)
                        {
                            num = 0;
                            waitTime = Time.timeSinceLevelLoad + 2f;
                        }
                        else
                        {
                            num++;
                            waitTime = Time.timeSinceLevelLoad + 2f;
                        }
                    }
                    else
                    {
                        num = Random.Range(0, waypoints.Length);
                        waitTime = Time.timeSinceLevelLoad + 2f;

                    }
                }
            }
        } 
    }

    void Patrol()
    {
        investigating = true;
        if (Time.timeSinceLevelLoad >= waitTime)
        {

            //gameObject.transform.LookAt(waypoints[num].transform.position);
            //  gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;

            //  Vector3 targetPostition = new Vector3(waypoints[num].transform.position.x,
            //                          this.transform.position.y,
            //                            waypoints[num].transform.position.z);
            // this.transform.LookAt(targetPostition);

            agent.SetDestination(waypoints[num].transform.position);

            if(flashLightBlindingLight)
            {
                agent.speed = slowedPatrol;
            }
            else
            {
                agent.speed = patrolSpeed;
            }
            
               
            

            

        }
        else
        {
            agent.speed = stopSpeed;
        }
    }

    void RunChase()
    {
        
            state = Nil_FOVdetection.State.CHASE;

            if(reInvestigate && Time.timeSinceLevelLoad >= reInvestigateTimer && !isinFov)
        {
            investigating = true;
        }
        
    }

    void Chase()
    {
        // Vector3 localPosition = player.transform.position - transform.position;
        //localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        // transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
        //gameObject.transform.LookAt(player.transform.position);

        soundDetected = false;
        timeSinceLastSeen = Time.timeSinceLevelLoad + 5;

        if (investigating)
        {
            investigateTime = Time.timeSinceLevelLoad + 1.5f;
            investigating = false;

            reInvestigate = true;
            reInvestigateTimer = Time.timeSinceLevelLoad + 5;





        }

         transform.LookAt(Player);
        if (Time.timeSinceLevelLoad >= investigateTime)
        {
            // transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime);
            //  rb.AddForce(transform.forward * thrust);

            agent.SetDestination(Player.transform.position);

            if (flashLightBlindingLight)
            {
                agent.speed = slowedChase;
            }
            else
            {
                agent.speed = chaseSpeed;
            }
        }
        else
        {
            agent.speed = stopSpeed;
        }
    }

    void RunInvestigating ()
    {
        state = Nil_FOVdetection.State.INVESTIGATE;

       
    }

    void Investigate()
    {
        if (!soundDetected)
        {
            if (Time.timeSinceLevelLoad <= timeSinceLastSeen)
            {
                 transform.LookAt(Player);
                // transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime);
                agent.SetDestination(Player.transform.position);
                agent.speed = chaseSpeed;
            }
            else
            {
                agent.speed = stopSpeed;
            }
        }
        else if(soundDetected)
        {
            if (soundInvestigateTimer >= Time.timeSinceLevelLoad)
            {
                // this.GetComponent<Rigidbody>().isKinematic = true;
                agent.speed = stopSpeed;
            }
            else if (soundInvestigateTimer <= Time.timeSinceLevelLoad)
            {
                //this.GetComponent<Rigidbody>().isKinematic = false;
                if(Time.timeSinceLevelLoad <= timeSinceLastSeen)
                {
                    moveToLocation = GameObject.FindGameObjectWithTag("SoundLocator");
                    //  transform.LookAt(moveToLocation.transform.position);
                    // transform.position = Vector3.SmoothDamp(transform.position, moveToLocation.transform.position, ref smoothVelocity, smoothTime);
                    agent.SetDestination(moveToLocation.transform.position);

                    if (flashLightBlindingLight)
                    {
                        agent.speed = slowedInvSound;
                    }
                    else
                    {
                        agent.speed = invSoundSpeed;
                    }
                }
            }
        }

        
    }

   void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "Sound" && !soundDetected && Time.timeSinceLevelLoad >= timeSinceLastSeen)
        {
            soundDetected = true;
            timeSinceLastSeen = Time.timeSinceLevelLoad + 7f;
            soundInvestigateTimer = Time.timeSinceLevelLoad + 2;
            moveToDestroyTimer = Time.timeSinceLevelLoad + 7f;
            Instantiate(soundLocation, Player.transform.position, Player.transform.rotation);
            
            destroyMoveTo = true;
            

         

        }

        if(theCollision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
            print("coll");
        }



    }

   

    

    

   



}





    



     



    


