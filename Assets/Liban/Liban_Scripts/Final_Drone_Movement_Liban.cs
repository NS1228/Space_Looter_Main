using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Drone_Movement_Liban : MonoBehaviour
{


    public float DroneSpeed;



    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Rigidbody>();

        DroneSpeed = 5.5f;


    }

    // Update is called once per frame
    void Update()
    {


        MovingDrone();


    }



        void MovingDrone()

        {

        

        float horizontal = Input.GetAxis("Horizontal");

        float vertical = Input.GetAxis("Vertical");


        Vector3 movinggg = new Vector3(-vertical, 0f, horizontal) * DroneSpeed * Time.deltaTime;

        transform.Translate(movinggg, Space.Self);
        
    }
}
