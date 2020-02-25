using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewActivateNV : MonoBehaviour
{
    public AudioSource NightVisionActivationAudio;

    private bool isNightVisionYeah;

    public Transform ThePlayer;

    private bool isZoomInYeah;

    public int Zoom = 22;

    public int Back = 70;

    public float smooth = 8.0f;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        RightCLick();

        LeftClick();

    }
    


        void LeftClick()


        {


        if (Input.GetMouseButtonDown(0))

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


                Light_Hold_Blue LLLBLUE = GameObject.Find("FlashLight").GetComponent<Light_Hold_Blue>();

                LLLBLUE.enabled = false;



              //  CameraSwitch switcham = GameObject.Find("camera switch script empty object new").GetComponent<CameraSwitch>();


              //  switcham.enabled = false;



            }



            else


            {





              //  DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

              //  NightVisionYeah.enabled = false;



           //     New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

         //   BlurrYEAHYEAHH.enabled = true;

               
            print("IT IS WORKING yeahyeah223");


                NightVisionActivationAudio.Play();


                ThePlayer.GetComponent<AudioSource>().minDistance = 1.05f;



                // print("IT IS WORKING yeahyeah223");


            Light_Hold_Blue LLLBLUE = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            LLLBLUE.enabled = false;


          //  Battery_Level batteryyeahyeah = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

          //  batteryyeahyeah.enabled = false;




            }
    }






    void RightCLick()

    {


        if(Input.GetMouseButtonDown(1))


        {


            isZoomInYeah = !isZoomInYeah;




        }




        if(isZoomInYeah)


        {


           


            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Zoom, Time.deltaTime * smooth);


            Light_Hold_Green LGGREEn = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            LGGREEn.enabled = false;


            DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

            NightVisionYeah.enabled = false;


            print("LETS GO!");


            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = true;


        }




        else


        {




            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, Back, Time.deltaTime * smooth);
             

            Light_Hold_Green LGGREEn = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            LGGREEn.enabled = false;


            New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = false;


        }


    }
}
