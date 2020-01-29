﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery_Level : MonoBehaviour
{


    public int StartingBattery = 1000;

    public int CurrentBattery;

    public int BonusBattery = 28;

    public Slider BatterySlider;

    public Light TorchLightBlue;

    public Light GlassLightBlue;

    public Light TorchLightGreen;

    public Light GlassLightGreen;

    public GameObject BatteryObject;

    public Text DangerTextyeahyeah;



    void Start()

    {

        CurrentBattery = StartingBattery;

        // CurrentBattery = TorchLight.intensity; 


    }

    public void TakeSomeBatteryBlue(int BlueAmount)

    {


        CurrentBattery -= BlueAmount;

        BatterySlider.value = CurrentBattery;


        if (CurrentBattery <= 0)


        {

            RunOut();

        }




        if (CurrentBattery > 0)


        {

            Revive();


        }



        if (CurrentBattery <= 450)

        {


            LowBattery();


        }


    }



    public void TakeSomeBatteryGreen (int GreenAmount)

    {

        CurrentBattery -= GreenAmount;

        BatterySlider.value = CurrentBattery;


        if(CurrentBattery <= 0)

        {

            RunOut();

        }




    }




    void RunOut()


    {


        TorchLightBlue.gameObject.SetActive(false);

        GlassLightBlue.gameObject.SetActive(false);

        TorchLightGreen.gameObject.SetActive(false);

        GlassLightGreen.gameObject.SetActive(false);


       //Battery_Level ThisScrtipt = GameObject.Find("flashlight").GetComponent<Battery_Level>();

       // ThisScrtipt.enabled = false;


        Light_Hold_Blue LIGHTHOLDblue = GameObject.Find("flashlight").GetComponent<Light_Hold_Blue>();

        LIGHTHOLDblue.enabled = false;


        Light_Hold_Green LIGHTHOLDgreen = GameObject.Find("flashlight").GetComponent<Light_Hold_Green>();

        LIGHTHOLDgreen.enabled = false;



        CurrentBattery = 0;


    }



    void Revive()


    {

        TorchLightBlue.gameObject.SetActive(true);


        Battery_Level ThisScrtipt = GameObject.Find("flashlight").GetComponent<Battery_Level>();

        ThisScrtipt.enabled = true;


        Light_Hold_Blue LIGHTHOLDBLUE = GameObject.Find("flashlight").GetComponent<Light_Hold_Blue>();

        LIGHTHOLDBLUE.enabled = true;


        Light_Hold_Green LIGHTHOLDGREEN = GameObject.Find("flashlight").GetComponent<Light_Hold_Green>();

        LIGHTHOLDGREEN.enabled = true;




    }





    void LowBattery()

    {


       // FlashingDanger DangerRED = GameObject.Find("DangerTEXT").GetComponent<FlashingDanger>();

      //  DangerRED.enabled = true;

        DangerTextyeahyeah.gameObject.SetActive(true);


    }










    void OnTriggerEnter (Collider other)
   

    {

        if(other.CompareTag("Battery"))
        

        {

            if(CurrentBattery < StartingBattery)

            {

                print("got it!");

                BatteryObject.SetActive(false);

                CurrentBattery += BonusBattery;

                if(CurrentBattery > StartingBattery)

                {

                    CurrentBattery = 1000;
                }






            }



        }
    }





}
