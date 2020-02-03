﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Off_TorchScript : MonoBehaviour
{

    public int SpeedBoost = 5;

    public Transform ThePlayer; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(0))
        {


            Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = false;


            Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = false;



            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed *= SpeedBoost;


            ThePlayer.GetComponent<AudioSource>().maxDistance = 7.0f;



        }





        if (Input.GetMouseButtonUp(0))


        {



            Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = true;


            Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = true;


            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed /= SpeedBoost;

            ThePlayer.GetComponent<AudioSource>().maxDistance = 1.05f;



        }







        if (Input.GetMouseButtonDown(1))


        {

            Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = false;


            Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = false;



            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed /= SpeedBoost;

           
            ThePlayer.GetComponent<AudioSource>().maxDistance = 0.79f;



        }




        if (Input.GetMouseButtonUp(1))



        {

            Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = true;


            Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            G_Light.enabled = true;



            NewMovementScript moving = GameObject.Find("player").GetComponent<NewMovementScript>();

            moving.MovementSpeed *= SpeedBoost;


            ThePlayer.GetComponent<AudioSource>().maxDistance = 1.05f;


        }













    }
}
