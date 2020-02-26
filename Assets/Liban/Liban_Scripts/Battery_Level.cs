using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battery_Level : MonoBehaviour
{


    public int StartingBattery = 1900;

    public int CurrentBattery;

    public int BonusBattery = 28;

    public Slider BatterySlider;

    public Light TorchLightBlue;

    //  public Light GlassLightBlue;

    //  public Light TorchLightGreen;

   // public Light GlassLightGreen;

    public GameObject BatteryObject;

    public Text DangerTextyeahyeah;




    void Start()

    {

        CurrentBattery = StartingBattery;

        // CurrentBattery = TorchLight.intensity; 

    }






    public void TakeSomeBatteryBlue(int BlueAmount)

    {


        CurrentBattery -= BlueAmount;

        BatterySlider.value = CurrentBattery;





        if (CurrentBattery <= 0)


        {

            RunOut();

        }

    

        if (CurrentBattery > 1)


        {

            Revive();


        }




        if (CurrentBattery <= 450)

        {


             LowBattery();

           // DangerTextyeahyeah.gameObject.SetActive(true);


        }




        if(CurrentBattery >= 456)

        {


            //DangerTextyeahyeah.gameObject.SetActive(false);

            AboveLowBattery();


        }


    }







        public void TakeSomeBatteryYellowFlashLight(int YellowFlashAmount)


        {

            CurrentBattery -= YellowFlashAmount;

            BatterySlider.value = CurrentBattery;


            if (CurrentBattery <= 0)


            {


                RunOut();

            }


        }






       void RunOut()


        {


            TorchLightBlue.gameObject.SetActive(false);

            //  GlassLightBlue.gameObject.SetActive(false);


          //  Battery_Level ThisScrtipt = GameObject.Find("flashlight").GetComponent<Battery_Level>();

           //  ThisScrtipt.enabled = false;


            Light_Hold_Blue LLLIGHTHOLDblue = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            LLLIGHTHOLDblue.enabled = false;



            Stun_Light_Liban SLYellow = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

            SLYellow.enabled = false;



            CurrentBattery = 0;


        }



       void Revive()

        {

            // TorchLightBlue.gameObject.SetActive(true);


           // Battery_Level ThisScrtipt = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

          //  ThisScrtipt.enabled = true;


        Light_Hold_Blue LIGHTHOLDBLUE = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

        LIGHTHOLDBLUE.enabled = true;





        Stun_Light_Liban Yellowwww = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

        Yellowwww.enabled = true;



        }





        void LowBattery()

        {




            DangerTextyeahyeah.gameObject.SetActive(true);


        }





    void AboveLowBattery()


    {




        DangerTextyeahyeah.gameObject.SetActive(false);


    }






        void OnTriggerEnter(Collider other)


        {

            if (other.gameObject.tag == "Battery")


            {

                if (CurrentBattery < StartingBattery)

                {

                    print("got it!");

                    Destroy(other.gameObject);

                    CurrentBattery += BonusBattery;

                    if (CurrentBattery > StartingBattery)

                    {

                        CurrentBattery = 1900;
                    }


                    BatterySlider.value = CurrentBattery;



                }



            }
        }
    }









