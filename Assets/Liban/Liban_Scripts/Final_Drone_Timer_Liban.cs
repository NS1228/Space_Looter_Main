using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Drone_Timer_Liban : MonoBehaviour
{


    public float DroneeeTimer = 16.0f;


    public static bool freeze;

    public static bool expose;


    public GameObject TheOneDrone;

    public GameObject TheOneTorch;



    private float OGSizeX = 830.96f;

    private float OGSizeY = 725.79f;

    private float OGSizeZ = 948.64f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        DroneeeTimer -= Time.deltaTime;


        int seccondsssss = (int)(DroneeeTimer % 60);



        TheOneTorch.SetActive(false);




        if(DroneeeTimer <= 16)

        {

            print("DroneTimer activated yh");

        }









        if(DroneeeTimer <= 8)



        {



            freeze = false;

            expose = false;




            TheOneDrone.GetComponent<BoxCollider>().size = new Vector3(OGSizeX, OGSizeY, OGSizeZ);



            TheOneDrone.GetComponent<SphereCollider>().radius = 521.5f;







        }







        if(DroneeeTimer <= 1)


        {


            DroneeeTimer = 16f;


            GetComponent<Final_Drone_Timer_Liban>().enabled = false;




        }


        
    }
}
