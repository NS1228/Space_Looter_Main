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
    public GameObject playerandClones;
    public GameObject detectionMeter;
    public GameObject drone;
    public GameObject emptyDrone;
   

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
    public float angularSpeed;
    private float immobolisedSpeed;
    private float immobolisedAngular;


    // private float speed;

    //FOVstuff
    [HeaderAttribute("Sight Detection")]
    public float defaultRadius;
    public float chaseRadius;
    public float defaultAngle;
    public float chaseAngle;
    private float maxAngle;
    private float maxRadius;

    //Gadget bools
    [HeaderAttribute("Gadget Bools")]
    public  bool flashLightBlindingLight;
    public  bool stunned;
    public static bool evacuate;
    public static bool subterfuge;
    public  bool immobilosingRipple;
    public bool droneIntel;
    public bool killDrone;

    //Gadget floats
    [HeaderAttribute("Gadget floats")]
    public float fakOffDrone;

    //Gadget Objects
    [HeaderAttribute("Gadget Objects")]
    public GameObject blindingLightObject;


    //stun stuff
    private float stunTimer;
    private bool stunable;

    //ghost mode
    public static bool phantasm;

    //evacuation
    public Transform evacuationPoint;
    public float evacuatestopTimer;

    //detection meter
    public bool detected;



    //Finite state machine
    public enum State
    {
        PATROL,
        CHASE,
        SEARCH,
        INVESTIGATE,
        STUN,
        EVACUATE,
        DRONE_TERMINATION
        


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
        stunable = true;
        evacuate = false;
        subterfuge = true;
        immobilosingRipple = false;
        immobolisedAngular = 0;
        immobolisedSpeed = 0;


    }

    // Update is called once per frame
    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.


        //checks if in fov (bool)
        isinFov = inFOV(transform, Player, maxAngle, maxRadius);


        if (isinFov && !stunned && !phantasm && !evacuate)
        {

            notChasing = false;
            notInvestigating = true;
            // print("inFOV");

        }
        else if (!isinFov && !stunned && !evacuate)
        {
            // print("NOTinFOV");
            if (Time.timeSinceLevelLoad >= timeSinceLastSeen)
            {
                notChasing = true;
                notInvestigating = true;
                soundDetected = false;
            }
            else if(Time.timeSinceLevelLoad < timeSinceLastSeen)
            {
                RunInvestigating();
                notInvestigating = false;

            }
        }

        if (soundDetected && notChasing && !stunned && !evacuate)
        {
            RunInvestigating();
            notInvestigating = false;
        }


        if (notChasing && !soundDetected && !stunned && !evacuate)
        {
            RunPatrol();
            maxRadius = defaultRadius;
            maxAngle = defaultAngle;
        }
        else
        {
            if (notInvestigating && !notChasing && !stunned && !phantasm && !evacuate)
            {
                RunChase();
                maxRadius = chaseRadius;
                maxAngle = chaseAngle;
            }
        }

        if(stunned && stunable)
        {
            RunStun();
            stunTimer = Time.timeSinceLevelLoad + 3;
            stunable = false;
        }

        if(evacuate && !stunned)
        {
            RunEvacuate();
        }

      

        if(killDrone && notChasing && !isinFov && !evacuate && !stunned)
        {
            RunDrone_Termination();
        }

       // print(Time.timeSinceLevelLoad);

         if(Input.GetKey(KeyCode.L))
         {
            killDrone = true;
         }
         if (Input.GetKey(KeyCode.M))
         {
             killDrone = false;
         }


        FindClosestEnemy();
        DroneStuff();
        UnSlowEnemies();







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
                case State.STUN:
                   Stun();
                    break;
                case State.EVACUATE:
                    Evacuate();
                    break;
                case State.DRONE_TERMINATION:
                    Drone_Termination();
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

        if (detected)
        {
            detectionMeter.GetComponent<Detection>().DetectedNo -= 1;
            detected = false;
        }

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

            if(flashLightBlindingLight && !immobilosingRipple)
            {
                agent.speed = slowedPatrol;
                agent.angularSpeed = angularSpeed;
            }
            else if(immobilosingRipple)
            {
                agent.speed = immobolisedSpeed;
                agent.angularSpeed = immobolisedAngular;
            }
            else if(!flashLightBlindingLight && !immobilosingRipple)
            {
                agent.speed = patrolSpeed;
                agent.angularSpeed = angularSpeed;
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

        if(!detected)
        {
            detectionMeter.GetComponent<Detection>().DetectedNo += 1;
            detected = true;
        }

        soundDetected = false;
        timeSinceLastSeen = Time.timeSinceLevelLoad + 5;

        if (investigating)
        {
            investigateTime = Time.timeSinceLevelLoad + 1.5f;
            investigating = false;

            reInvestigate = true;
            reInvestigateTimer = Time.timeSinceLevelLoad + 5;





        }

        if (!subterfuge)
        {
            transform.LookAt(Player);
        }
        else
        {
            transform.LookAt(playerandClones.transform.position);
        }

        if (!subterfuge)
        {
            if (Time.timeSinceLevelLoad >= investigateTime)
            {
                // transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime);
                //  rb.AddForce(transform.forward * thrust);

                agent.SetDestination(Player.transform.position);

                if (flashLightBlindingLight && !immobilosingRipple)
                {
                    agent.speed = slowedChase;
                    agent.angularSpeed = angularSpeed;
                }
                else if (immobilosingRipple)
                {
                    agent.speed = immobolisedSpeed;
                    agent.angularSpeed = immobolisedAngular;
                }
                else if (!flashLightBlindingLight && !immobilosingRipple)
                {
                    agent.speed = chaseSpeed;
                    agent.angularSpeed = angularSpeed;
                }
            }
            else
            {
                agent.speed = stopSpeed;
            }
        }

        else if (subterfuge)
        {

            if (Time.timeSinceLevelLoad >= investigateTime)
            {
                // transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime);
                //  rb.AddForce(transform.forward * thrust);

                agent.SetDestination(playerandClones.transform.position);
                if (flashLightBlindingLight && !immobilosingRipple)
                {
                    agent.speed = slowedChase;
                    agent.angularSpeed = angularSpeed;
                }
                else if (immobilosingRipple)
                {
                    agent.speed = immobolisedSpeed;
                    agent.angularSpeed = immobolisedAngular;
                }
                else if (!flashLightBlindingLight && !immobilosingRipple)
                {
                    agent.speed = chaseSpeed;
                    agent.angularSpeed = angularSpeed;
                }
            }
            else
            {
                agent.speed = stopSpeed;
            }
        }
    }


            
        
    


    void RunInvestigating ()
    {
        state = Nil_FOVdetection.State.INVESTIGATE;

       
    }

    void Investigate()
    {
        if (!subterfuge)
        {
            if (!soundDetected && !phantasm)
            {
                if (flashLightBlindingLight && !immobilosingRipple)
                {
                    agent.speed = slowedChase;
                    agent.angularSpeed = angularSpeed;
                }
                else if (immobilosingRipple)
                {
                    agent.speed = immobolisedSpeed;
                    agent.angularSpeed = immobolisedAngular;
                }
                else if (!flashLightBlindingLight && !immobilosingRipple)
                {
                    agent.speed = chaseSpeed;
                    agent.angularSpeed = angularSpeed;
                }
            
            else
            {
                agent.speed = stopSpeed;
            }
            }
            else if (soundDetected)
            {
                if (soundInvestigateTimer >= Time.timeSinceLevelLoad)
                {
                    // this.GetComponent<Rigidbody>().isKinematic = true;
                    agent.speed = stopSpeed;
                }
                else if (soundInvestigateTimer <= Time.timeSinceLevelLoad)
                {
                    //this.GetComponent<Rigidbody>().isKinematic = false;
                    if (Time.timeSinceLevelLoad <= timeSinceLastSeen)
                    {
                        moveToLocation = GameObject.FindGameObjectWithTag("SoundLocator");
                        //  transform.LookAt(moveToLocation.transform.position);
                        // transform.position = Vector3.SmoothDamp(transform.position, moveToLocation.transform.position, ref smoothVelocity, smoothTime);
                        agent.SetDestination(moveToLocation.transform.position);

                        if (flashLightBlindingLight && !immobilosingRipple)
                        {
                            agent.speed = slowedInvSound;
                            agent.angularSpeed = angularSpeed;
                        }
                        else if (immobilosingRipple)
                        {
                            agent.speed = immobolisedSpeed;
                            agent.angularSpeed = immobolisedAngular;
                        }
                        else if (!flashLightBlindingLight && !immobilosingRipple)
                        {
                            agent.speed = invSoundSpeed;
                            agent.angularSpeed = angularSpeed;
                        }
                    }
                }
            }
        }
        else if (subterfuge)
        {
            if (!soundDetected && !phantasm)
            {
                if (Time.timeSinceLevelLoad <= timeSinceLastSeen)
                {
                    transform.LookAt(playerandClones.transform.position);
                    // transform.position = Vector3.SmoothDamp(transform.position, Player.position, ref smoothVelocity, smoothTime);
                    agent.SetDestination(playerandClones.transform.position);
                    if (flashLightBlindingLight && !immobilosingRipple)
                    {
                        agent.speed = slowedChase;
                        agent.angularSpeed = angularSpeed;
                    }
                    else if (immobilosingRipple)
                    {
                        agent.speed = immobolisedSpeed;
                        agent.angularSpeed = immobolisedAngular;
                    }
                    else if (!flashLightBlindingLight && !immobilosingRipple)
                    {
                        agent.speed = chaseSpeed;
                        agent.angularSpeed = angularSpeed;
                    }
                }
                else
                {
                    agent.speed = stopSpeed;
                }
            }
            else if (soundDetected)
            {
                if (soundInvestigateTimer >= Time.timeSinceLevelLoad)
                {
                    // this.GetComponent<Rigidbody>().isKinematic = true;
                    agent.speed = stopSpeed;
                }
                else if (soundInvestigateTimer <= Time.timeSinceLevelLoad)
                {
                    //this.GetComponent<Rigidbody>().isKinematic = false;
                    if (Time.timeSinceLevelLoad <= timeSinceLastSeen)
                    {
                        moveToLocation = GameObject.FindGameObjectWithTag("SoundLocator");
                        //  transform.LookAt(moveToLocation.transform.position);
                        // transform.position = Vector3.SmoothDamp(transform.position, moveToLocation.transform.position, ref smoothVelocity, smoothTime);
                        agent.SetDestination(moveToLocation.transform.position);

                        if (flashLightBlindingLight && !immobilosingRipple)
                        {
                            agent.speed = slowedInvSound;
                            agent.angularSpeed = angularSpeed;
                        }
                        else if (immobilosingRipple)
                        {
                            agent.speed = immobolisedSpeed;
                            agent.angularSpeed = immobolisedAngular;
                        }
                        else if (!flashLightBlindingLight && !immobilosingRipple)
                        {
                            agent.speed = invSoundSpeed;
                            agent.angularSpeed = angularSpeed;
                        }
                    }
                }
            }


        }

    }
        
       
    

    void RunStun()
    {
        state = Nil_FOVdetection.State.STUN;
    }

    void Stun()
    {
        if (stunTimer >= Time.timeSinceLevelLoad)
        {
            agent.speed = 0;
            agent.angularSpeed = 0;
            // something to stop looking at the player
        }
        else
        {
            stunned = false;
            stunable = true;
        }
    }

    void RunEvacuate()
    {
        state = Nil_FOVdetection.State.STUN;
    }

    void Evacuate ()
    {

        if(evacuatestopTimer >= Time.timeSinceLevelLoad)
        {
            agent.speed = 0;
        }
        else
        {
            evacuate = false;
        }
        

        if (this.transform.position == evacuationPoint.transform.position)
        {
            evacuatestopTimer = Time.timeSinceLevelLoad + 2;

        }
        else
        {
            agent.SetDestination(evacuationPoint.transform.position);

            
        }
       
    }

    void RunDrone_Termination()
    {
        state = Nil_FOVdetection.State.DRONE_TERMINATION;
        
    }

   void Drone_Termination()
    {
        
        agent.SetDestination(drone.transform.position);
        transform.LookAt(drone.transform.position);

       if (flashLightBlindingLight && !immobilosingRipple)
        {
            agent.speed = slowedChase;
            agent.angularSpeed = angularSpeed;
        }
        else if (immobilosingRipple)
        {
            agent.speed = immobolisedSpeed;
            agent.angularSpeed = immobolisedAngular;
        }
        else if (!flashLightBlindingLight && !immobilosingRipple)
        {
            agent.speed = chaseSpeed;
            agent.angularSpeed = angularSpeed;
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

     




            if (theCollision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
            print("coll");
        }

            if(theCollision.gameObject.tag == "Drone")
        {
            Destroy(theCollision.gameObject);
        }



    }

    void OnCollisionEnter (Collision coll)
    {
        if(coll.gameObject.tag == "Drone")
        {
            Destroy(coll.gameObject);
        }
    }

    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Player");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
                playerandClones = closest.gameObject;
            }
        }
        return closest;
       
    }

    public void DroneStuff()
    {
        if (GameObject.FindGameObjectWithTag("Drone") == null)
        {
            drone = emptyDrone;
            immobilosingRipple = false;
            this.GetComponent<Outline>().enabled = false;
            droneIntel = false;
            killDrone = false;
        }
        else
        {
            drone = GameObject.FindGameObjectWithTag("Drone");
        }

        var distance = Vector3.Distance(this.transform.position, drone.transform.position);
        if (distance >= fakOffDrone)
        {
            immobilosingRipple = false;
            this.GetComponent<Outline>().enabled = false;
            droneIntel = false;
            killDrone = false;

        }
    }


    public void UnSlowEnemies()
    {

        blindingLightObject = GameObject.FindGameObjectWithTag("BlueLight");
       
        if (blindingLightObject == null)
        {
            flashLightBlindingLight = false;
        }
    }









}





    



     



    


