using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.PostProcessing;

public class CameraZoom : MonoBehaviour
{


    public int Zoom = 22;

    public int Normal = 70;

    public float SmoothYeah = 7.8f;


    private bool isZoomed = false;

    public AudioSource ZoomInSoundYeahYeah;

   // public AudioSource ZoomInSoundYeahYeah2;




    // Start is called before the first frame update
    void Start()
    {


       
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(1))

        {

            isZoomed = !isZoomed;
        }



        if (isZoomed)

        {



            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Zoom, Time.deltaTime * SmoothYeah);


            DeferredNightVisionEffect NightVisionYeah2 = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah2.enabled = false;


            New_Motion_XBlur BlurrYEAHYEAHH7 = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH7.enabled = true;




        }


        else




            {



            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Normal, Time.deltaTime * SmoothYeah);


            ZoomInSoundYeahYeah.Play();


            DeferredNightVisionEffect NightVisionYeah2 = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah2.enabled = true;


            New_Motion_XBlur BlurrYEAHYEAHH7 = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH7.enabled = false;



        }

    }
        

    }

