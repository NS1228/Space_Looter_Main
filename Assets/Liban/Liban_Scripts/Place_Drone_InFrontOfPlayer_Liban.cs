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

    public GameObject Torch;




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



            //Torch.SetActive(false);
            DaDrone.SetActive(true);

            Final_Drone_Movement_Liban FDM45 = GameObject.Find("Drone Skin").GetComponent<Final_Drone_Movement_Liban>();


            FDM45.enabled = true;

          


            DaDrone.transform.position = WhereTheDroneWillSpawn.transform.position;



        



            DroneCamera.gameObject.SetActive(true);




            LemarMovment LMovementyh = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();


            LMovementyh.enabled = false;


            DroneCameraLIVE.gameObject.SetActive(true);




            LemarCamera LCAM = GameObject.Find("Main Camera").GetComponent<LemarCamera>();


            LCAM.RotateSpeed = 0f;





            Final_First_Ability_Drone_Liban ASW = GameObject.Find("Activate Drone first ability").GetComponent<Final_First_Ability_Drone_Liban>();

            ASW.enabled = true;




            Final_Second_Drone_Ability_Liban SDFG = GameObject.Find("Activate Drone second ability").GetComponent<Final_Second_Drone_Ability_Liban>();

            SDFG.enabled = true;



          



            DHealth.gameObject.SetActive(true);




            LemarCamera DroneCAMM = GameObject.Find("Drone Camera").GetComponent<LemarCamera>();


            DroneCAMM.RotateSpeed = 2;





            DroneHealth_Script DHEALTHHyhyh = GameObject.FindWithTag("Dronee").GetComponent<DroneHealth_Script>();

            DHEALTHHyhyh.enabled = true;







            Final_Drone_Timer_Liban TIMEII = GameObject.FindWithTag("Dronee").GetComponent<Final_Drone_Timer_Liban>();


            TIMEII.enabled = true;

            


        }
    




        


    }
}
