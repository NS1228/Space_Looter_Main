using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{


    public Camera FirstPersonCamera;

    public Camera OriginalCamera;

    private bool SwitchYeah;

    private bool ZoomInYeah;

    public int ZoomIn = 22;

    public int BackNormal = 70;

    public float Smooth = 7.9f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {




        if (Input.GetMouseButtonDown(0))

        {



            SwitchYeah = !SwitchYeah;




        }





        if (SwitchYeah)


        {

            FirstPersonCamera.gameObject.SetActive(true);

            OriginalCamera.gameObject.SetActive(false);




            DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = true;





            GameObject[] da_troch3 = GameObject.FindGameObjectsWithTag("FlashLight");


            foreach (GameObject gos in da_troch3)

            {

                gos.GetComponent<Stun_Light_Liban>().enabled = false;

                gos.GetComponent<Light_Hold_Blue>().enabled = false;


            }




            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = true;



            CameraZoom Zoomy = GameObject.Find("FPSMainCamera").GetComponent<CameraZoom>();

            Zoomy.enabled = true;





        }





        else





        {


            print("ghgh");


            OriginalCamera.gameObject.SetActive(true);

            FirstPersonCamera.gameObject.SetActive(false);







            DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = false;






            Light_Hold_Blue LLBLUE = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            LLBLUE.enabled = false;






           







        }

    }


    }





   


    









 






     