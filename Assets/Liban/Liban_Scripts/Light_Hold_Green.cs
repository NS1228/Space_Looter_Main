﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Hold_Green : MonoBehaviour
{

    public Light TorchLightGreen;

    public Light GlassLightGreen;

    public AudioSource LightSwitchSound;

    public int TakeAwayBattery = 8;




    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Light>();



    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButton(1))

        {



            TorchLightGreen.gameObject.SetActive(true);


            GlassLightGreen.gameObject.SetActive(true);


            LightSwitchSound.Play();


            GetComponent<Battery_Level>().TakeSomeBatteryGreen(TakeAwayBattery);




        }

        else

        {


            if (Input.GetMouseButtonUp(1))


            {

                TorchLightGreen.gameObject.SetActive(false);


                GlassLightGreen.gameObject.SetActive(false);


                LightSwitchSound.Play();


            }
        }







    }
}
