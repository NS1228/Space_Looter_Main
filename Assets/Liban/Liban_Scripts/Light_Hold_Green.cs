using System.Collections;
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
        AIFlashReact();

        if (Input.GetMouseButton(0))

        {



            TorchLightGreen.gameObject.SetActive(true);


            GlassLightGreen.gameObject.SetActive(true);


            LightSwitchSound.Play();


        //    GetComponent<Battery_Level>().TakeSomeBatteryGreen(TakeAwayBattery);




        }

        else

        {


            if (Input.GetMouseButtonUp(0))


            {

                TorchLightGreen.gameObject.SetActive(false);


                GlassLightGreen.gameObject.SetActive(false);


              //  LightSwitchSound.Play();


            }
        }



        void AIFlashReact()


        {

            if(AI_Reacting_To_GreenLight_Liban.SlowingDownEnemy == true)


            {


               // Nil_FOVdetection.flashLightBlindingLight = true;


            }


            else

            {


                //Nil_FOVdetection.flashLightBlindingLight = false;

            }


        }




        if (TorchLightGreen.isActiveAndEnabled == false)



        {

           // Nil_FOVdetection.flashLightBlindingLight = false;


        }


    }
}
