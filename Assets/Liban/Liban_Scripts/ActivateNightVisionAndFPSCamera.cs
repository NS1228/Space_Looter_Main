using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ActivateNightVisionAndFPSCamera : MonoBehaviour
{
    public AudioSource NightVisionActivationAudio;

    private bool isNightVisionYeah;



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


            NightVisionActivationAudio.Play();



        }


        else


        {

            DeferredNightVisionEffect NightVisionYeah = GameObject.Find("FPSMainCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = false;




        }


    }
}
