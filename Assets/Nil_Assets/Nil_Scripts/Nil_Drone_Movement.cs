using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Nil_Drone_Movement : MonoBehaviour
{ 
public NavMeshAgent agent;
public GameObject player;

public GameObject[] waypoints;
public int num = 0;

public float minDist;
public float speed;
public float smoothTime = 10.0f;
public float runSpeed;
//Vector3 used to store the velocity of the enemy
private Vector3 smoothVelocity = Vector3.zero;

    public bool rand = false;
public bool go = true;

public float waitTime;
public float investigateTime;
public bool reInvestigate;
public float reInvestigateTimer;
public bool investigating;
public float chaseTimer;
public bool chase;

    private Vector3 newYPos;
    public static bool droneCanAttack;

public enum State
{
    PATROL,
    CHASE,
    SEARCH,
    INVESTIGATE


}

public bool notChasing;
public bool notInvestigating;

public State state;
private bool alive;

public Transform Player;
public float maxAngle;
public float maxRadius;

public float timeSinceLastSeen;

private bool isinFov = false;

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

    for (int i = 0; i < count + 1; i++)
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
    state = Nil_Drone_Movement.State.PATROL;
    alive = true;
    investigating = true;
    reInvestigate = false;
    notInvestigating = true;
    StartCoroutine("FSM");

}

// Update is called once per frame
void Update()
{
    // Choose the next destination point when the agent gets
    // close to the current one.


    //checks if in fov (bool)
    isinFov = inFOV(transform, Player, maxAngle, maxAngle);

    if (isinFov)
    {

        notChasing = false;


    }
    else if (!isinFov)
    {
        if (Time.timeSinceLevelLoad >= timeSinceLastSeen)
        {
            notChasing = true;
            notInvestigating = true;
        }
        else
        {
            RunInvestigating();
            notInvestigating = false;

        }
    }




    if (notChasing)
    {
        RunPatrol();
        maxRadius = 15;
    }
    else
    {
        if (notInvestigating)
        {
            RunChase();
            maxRadius = 20;
        }
    }


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

                state = Nil_Drone_Movement.State.PATROL;
                

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
        droneCanAttack = false;
    if (Time.timeSinceLevelLoad >= waitTime)
    {
        gameObject.transform.LookAt(waypoints[num].transform.position);
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
}

void RunChase()
{

    state = Nil_Drone_Movement.State.CHASE;

    if (reInvestigate && Time.timeSinceLevelLoad >= reInvestigateTimer && !isinFov)
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

        float distance = Vector3.Distance(this.transform.position, Player.transform.position);

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
            droneCanAttack = true;
            if (distance >= 10)
            {
                newYPos = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, newYPos, runSpeed * Time.deltaTime);
            }
            else if(distance < 6)
            {
                newYPos = new Vector3(Player.transform.position.x + 4, transform.position.y, Player.transform.position.z + 4);
                transform.position = Vector3.MoveTowards(transform.position, newYPos, runSpeed * Time.deltaTime);

            }
        }
    }

void RunInvestigating()
{
    state = Nil_Drone_Movement.State.INVESTIGATE;
}

void Investigate()
{
        float distance = Vector3.Distance(this.transform.position, Player.transform.position);
        if (Time.timeSinceLevelLoad <= timeSinceLastSeen)
    {
            droneCanAttack = true;
            transform.LookAt(Player);
            if (distance >= 10)
            {
                newYPos = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z);
                transform.position = Vector3.MoveTowards(transform.position, newYPos, runSpeed * Time.deltaTime);
            }
            else if(distance < 6)
            {
                newYPos = new Vector3(Player.transform.position.x + 4, transform.position.y, Player.transform.position.z + 4);
                transform.position = Vector3.MoveTowards(transform.position, newYPos, runSpeed * Time.deltaTime);
            }
        }
}

   

   
}
