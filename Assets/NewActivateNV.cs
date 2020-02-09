using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewActivateNV : MonoBehaviour
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



        if (Input.GetKeyDown(KeyCode.O))


        {

            isNightVisionYeah = !isNightVisionYeah;





        }

        if (isNightVisionYeah)


        {




            DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = true;


            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = false;



            ThePlayer.GetComponent<AudioSource>().minDistance = 10.0f;



            print("IT IS WORKING yeahyeah");






        }



        else


        {


            DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = false;



            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = true;

            print("IT IS WORKING yeahyeah223");


            NightVisionActivationAudio.Play();


            ThePlayer.GetComponent<AudioSource>().minDistance = 1.05f;



          //  New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

          //  BlurrYEAHYEAHH.enabled = true;

           // print("IT IS WORKING yeahyeah223");






        }


    }
}
