using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Off_TorchScript : MonoBehaviour
{

    public int SpeedBoost = 4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {


            Light_Hold_Blue B_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = false;


            Light_Hold_Green G_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = false;



            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed *= SpeedBoost;


        }





        if (Input.GetMouseButtonUp(0))


        {



            Light_Hold_Blue B_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = true;


            Light_Hold_Green G_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = true;


            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed /= SpeedBoost;



        }







        if (Input.GetMouseButtonDown(1))


        {

            Light_Hold_Blue B_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = false;


            Light_Hold_Green G_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = false;



            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed /= SpeedBoost;


        }




        if (Input.GetMouseButtonUp(1))



        {

            Light_Hold_Blue B_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = true;


            Light_Hold_Green G_Light = GameObject.Find("flashlight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = true;



            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed *= SpeedBoost;


        }













    }
}
