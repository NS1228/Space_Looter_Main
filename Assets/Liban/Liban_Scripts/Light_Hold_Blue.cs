using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Light_Hold_Blue : MonoBehaviour
{


    public Light TorchLightBlue;

  //  public Light GlassLightBlue;

    public AudioSource LightSwitchSound;

    public int TakeAwayBatteryBlue = 20;



    // Start is called before the first frame update
    void Start()
    {


        GetComponent<Light>();
        
    }

    // Update is called once per frame
    public void Update()
    {




        if(Input.GetMouseButton(0))

        {



            TorchLightBlue.gameObject.SetActive(true);


         //   GlassLightBlue.gameObject.SetActive(true);

          
            LightSwitchSound.Play();


            GetComponent<Battery_Level>().TakeSomeBatteryBlue(TakeAwayBatteryBlue);




        }

         else

        {


            if(Input.GetMouseButtonUp(0))


            {

                TorchLightBlue.gameObject.SetActive(false);


            //    GlassLightBlue.gameObject.SetActive(false);


              //  LightSwitchSound.Play();


            }
        }


        
        
        
        


    }
}
