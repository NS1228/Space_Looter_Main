using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Stun_Light_Liban : MonoBehaviour
{



    public GameObject StunLight;

    public AudioSource CameraFlash;

    public float CameraflashTimer;

    public int TakeALotOfBattery = 800;




    // Start is called before the first frame update
    void Start()
    {


        GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {


        TimeFlash();

        AICameraFlashStun();



        if(Input.GetMouseButtonDown(1))


        {


            StunLight.gameObject.SetActive(true);


            CameraFlash.Play();



            GetComponent<Battery_Level>().TakeSomeBatteryYellowFlashLight(TakeALotOfBattery);


            CameraflashTimer = Time.timeSinceLevelLoad + 0.01f;


        }





        if(Input.GetMouseButtonUp(1))


        {


            StunLight.gameObject.SetActive(false);



        }





        void TimeFlash()

        {


            if (Time.timeSinceLevelLoad >= CameraflashTimer)


            {


                StunLight.SetActive(false);



            } 

        }



        void AICameraFlashStun()


        {


            if(AI_Camera_FlashStun_React_Liban.StunningEnemy == true)


            {


                Nil_FOVdetection.stunned = true;


                AI_Camera_FlashStun_React_Liban.StunningEnemy = false;


            }



        }



        
    }
}
