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



            //    PostProcessingBehaviour VisualYeahYeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();

            //  VisualYeahYeah.enabled = false;


            Moving_Blurr_Effect_X BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<Moving_Blurr_Effect_X>();

            BlurrYEAHYEAHH.enabled = false;
          

        }



        else


        {


            DeferredNightVisionEffect NightVisionYeah = GameObject.Find("FPSMainCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = false;


            NightVisionActivationAudio.Play();


            ThePlayer.GetComponent<AudioSource>().minDistance = 1.05f;


            //   PostProcessingBehaviour VisualYeahYeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();

            //  VisualYeahYeah.enabled = true;


            Moving_Blurr_Effect_X BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<Moving_Blurr_Effect_X>();

            BlurrYEAHYEAHH.enabled = true;




        }


    }
}
