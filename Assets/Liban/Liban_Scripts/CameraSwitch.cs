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



            //    Battery_Level BL_Battery = BL_Battery = GameObject.FindWithTag("LemarCamera").GetComponent<Battery_Level>();

            //    BL_Battery.enabled = true;


               Light_Hold_Blue LLBLUE = GameObject.Find("FlashLight").GetComponent<Light_Hold_Blue>();

               LLBLUE.enabled = false;




               New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = false;

        }



        else

        {


            OriginalCamera.gameObject.SetActive(true);

            FirstPersonCamera.gameObject.SetActive(false);


            //name of night vision script

               DeferredNightVisionEffect NightVisionYeah = GameObject.FindWithTag("LemarCamera").GetComponent<DeferredNightVisionEffect>();

              NightVisionYeah.enabled = false;


            //  Battery_Level BL_Battery = BL_Battery = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

            //  BL_Battery.enabled = false;


            Light_Hold_Blue LLBLUE = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            LLBLUE.enabled = false;    


            Light_Hold_Green LGGREEn = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            LGGREEn.enabled = true;




           New_Motion_XBlur BlurrYEAHYEAHH = GameObject.Find("Character").GetComponent<New_Motion_XBlur>();

            BlurrYEAHYEAHH.enabled = false;





        }






    }
}





     