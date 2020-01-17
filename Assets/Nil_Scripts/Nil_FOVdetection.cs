using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Nil_FOVdetection : MonoBehaviour
{
   
    public NavMeshAgent agent;


   

    public enum State
    {
        PATROL,
        CHASE,
        SEARCH,
        INVESTIGATE


    }



    public State state;
    private bool alive;


    public float speed = 10f;
   

    public List<Transform> wayPointsList = new List<Transform>();

    public Transform currentWaypoint;

    public int wayPointNumber = 0;

    



    public Transform Player;
    public float maxAngle;
    public float maxRadius;

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
        state = Nil_FOVdetection.State.PATROL;
        alive = true;

        StartCoroutine("FSM");


        currentWaypoint = wayPointsList[wayPointNumber];



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

        }
        //Vector3 relativePos = currentWaypoint.position - transform.position;
       // transform.rotation = Quaternion.LookRotation(relativePos);


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
            }
            yield return null;

        }


    }

    void Patrol()
    {
        float distanceToCurrent = Vector2.Distance(transform.position, currentWaypoint.position);
        
       
            if (distanceToCurrent == 0)
        {
            if (wayPointNumber != wayPointsList.Count - 1)
            {
                wayPointNumber++;
                currentWaypoint = wayPointsList[wayPointNumber];
            }
            else
            {
                wayPointNumber = 0;
                currentWaypoint = wayPointsList[wayPointNumber];
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, speed * Time.deltaTime);



    } 
}


    


