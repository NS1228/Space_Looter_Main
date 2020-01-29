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


        if (Input.GetKeyDown(KeyCode.Y))

        {

            isZoomed = !isZoomed;
        }



        if (isZoomed)

        {



            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Zoom, Time.deltaTime * SmoothYeah);


            PostProcessingBehaviour ImageBlur = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            ImageBlur.enabled = false;
           

        }



                else




            {


            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Normal, Time.deltaTime * SmoothYeah);


           ZoomInSoundYeahYeah.Play();


            PostProcessingBehaviour ImageBlur = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            ImageBlur.enabled = true;





        }

    }
        

    }

