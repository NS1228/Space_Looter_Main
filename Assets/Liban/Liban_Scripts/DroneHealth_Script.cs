﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DroneHealth_Script : MonoBehaviour
{


    public float StartingDroneHealth = 300.0f;

    public float CurrentDroneHealth;

    public Slider DroneHealthBar;

    public float DroneBatteryDraineryh = 400.0f;

    private float DroneBatteryTimer = 0.3f;

    public GameObject DaTorch;


    // Start is called before the first frame update
    private void Start()
    {




          CurrentDroneHealth = StartingDroneHealth;


     


    }




     void Update()
    {

        TakeBattery();

       // DeathDeath();



    }





     void TakeBattery()


    {

        DroneBatteryTimer -= Time.deltaTime;



        if (Time.deltaTime >= DroneBatteryTimer)

        {


            CurrentDroneHealth -= DroneBatteryDraineryh;


            DroneHealthBar.value = CurrentDroneHealth;



        }

        if(CurrentDroneHealth <= 0)



        {



            DeathDeath();



            LemarCamera LMKJH = GameObject.Find("Main Camera").GetComponent<LemarCamera>();


            LMKJH.RotateSpeed = 10;




            LemarMovment TYU4567 = GameObject.Find("newPlayer").GetComponent<LemarMovment>();


            TYU4567.enabled = true;


            DaTorch.SetActive(true);



        }


    }









     void DeathDeath()


    {


        gameObject.SetActive(false);
        CurrentDroneHealth = 600f;
        GetComponent<Place_Drone_InFrontOfPlayer_Liban>().DroneCameraLIVE.enabled = false;


        DroneHealthBar.gameObject.SetActive(false);
        DaTorch.SetActive(true);



    }



      
  }


    




      
