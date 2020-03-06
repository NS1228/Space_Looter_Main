using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Place_Drone_InFrontOfPlayer_Liban : MonoBehaviour
{



    public GameObject DaDrone;

    public Transform WhereTheDroneWillSpawn;

    public Camera DroneCamera;

    public Camera ThePlayersCamera;

    public bool ChangeCamera = false;

    public RawImage DroneCameraLIVE;

    public GameObject DHealth;




    // Start is called before the first frame update
    void Start()
    {






    }

    // Update is called once per frame
    void Update()
    {


        //activate the drone movmeent script in here 


        YeahChangeCam();



    }





    void YeahChangeCam()


    {



        if (Input.GetKeyDown(KeyCode.Q))


        {










            DaDrone.transform.position = WhereTheDroneWillSpawn.transform.position;



            WhereTheDroneWillSpawn.parent = null;



            DroneCamera.gameObject.SetActive(true);




            // ThePlayersCamera.gameObject.SetActive(false);





            Drone_Movement_Liban LibanDrone = GameObject.FindWithTag("Dronee").GetComponent<Drone_Movement_Liban>();


            LibanDrone.enabled = true;




            // NewMovementScript DRNEMV = GameObject.FindWithTag("Dronee").GetComponent<NewMovementScript>();

            // DRNEMV.enabled = true;




            LemarMovment LMovementyh = GameObject.Find("newPlayer").GetComponent<LemarMovment>();


            LMovementyh.enabled = false;


            DroneCameraLIVE.gameObject.SetActive(true);




            LemarCamera LCAM = GameObject.Find("Main Camera").GetComponent<LemarCamera>();


            LCAM.RotateSpeed = 0f;




            Drone_First_Ability_Liban GVBN3434 = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();


            GVBN3434.enabled = true;




            Drone_Second_ability_Liban QWERTY = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


            QWERTY.enabled = true;




            DHealth.gameObject.SetActive(true);




            LemarCamera DroneCAMM = GameObject.Find("Drone Camera").GetComponent<LemarCamera>();


            DroneCAMM.RotateSpeed = 2;





            DroneHealth_Script DHEALTHHyhyh = GameObject.FindWithTag("Dronee").GetComponent<DroneHealth_Script>();

            DHEALTHHyhyh.enabled = true;


        }
    





        


        {





            Drone_Movement_Liban LibanDrone = GameObject.FindWithTag("Dronee").GetComponent<Drone_Movement_Liban>();


            LibanDrone.enabled = false;



            LemarMovment LMovementyh = GameObject.Find("newPlayer").GetComponent<LemarMovment>();


            LMovementyh.enabled = true;





            DroneCameraLIVE.gameObject.SetActive(false);






            Drone_First_Ability_Liban GVBN3434 = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();


            GVBN3434.enabled = false;






            Drone_Second_ability_Liban QWERTY = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


            QWERTY.enabled = false;




            DHealth.gameObject.SetActive(false);





            LemarCamera LCAM = GameObject.Find("Main Camera").GetComponent<LemarCamera>();


            LCAM.RotateSpeed = 10f;




            LemarCamera DroneCAMM = GameObject.Find("Drone Camera").GetComponent<LemarCamera>();


            DroneCAMM.RotateSpeed = 0;




            // NewMovementScript DRNEMV = GameObject.FindWithTag("Dronee").GetComponent<NewMovementScript>();

            // DRNEMV.enabled = false;




            DroneHealth_Script DDHEEALLTH = GameObject.FindWithTag("Dronee").GetComponent<DroneHealth_Script>();


            DDHEEALLTH.enabled = false; 



        }



    }
}
