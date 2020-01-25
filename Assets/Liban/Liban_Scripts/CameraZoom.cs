using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{


    public int Zoom = 20;

    public int Normal = 60;

    public float SmoothYeah = 7.8f;

    private bool isZoomed = false;


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



        }



                else




            {


            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Normal, Time.deltaTime * SmoothYeah);




            }

        }
        

    }

