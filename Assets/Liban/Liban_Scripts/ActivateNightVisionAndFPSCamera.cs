using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.PostProcessing;

public class ActivateNightVisionAndFPSCamera : MonoBehaviour
{
    public AudioSource NightVisionActivationAudio;

    private bool isNightVisionYeah;

    public Transform ThePlayer;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if( Input.GetKeyDown(KeyCode.O))


        {

            isNightVisionYeah = !isNightVisionYeah;





        }

        if(isNightVisionYeah)


        {

             DeferredNightVisionEffect NightVisionYeah = GameObject.Find("FPSMainCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = true;



             ThePlayer.GetComponent<AudioSource>().minDistance = 10.0f;




            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("player").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = false;


            print("IT IS WORKING");
          

        }



        else


        {


            DeferredNightVisionEffect NightVisionYeah = GameObject.Find("FPSMainCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = false;


            NightVisionActivationAudio.Play();


            ThePlayer.GetComponent<AudioSource>().minDistance = 1.05f;



            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("player").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = true;




        }


    }
}
