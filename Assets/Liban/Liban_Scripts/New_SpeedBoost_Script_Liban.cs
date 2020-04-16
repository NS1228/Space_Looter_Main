using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_SpeedBoost_Script_Liban : MonoBehaviour
{

    public float PowerUpTimer = 16;


    public Transform ThePlayerYHYHYH;


    public GameObject TheShoeCMON;





    // Start is called before the first frame update
    void Start()
    {







    }

    // Update is called once per frame
    void Update()

    {












        PowerUpTimer -= Time.deltaTime;


        int secs = (int)(PowerUpTimer % 60);











        if (PowerUpTimer <= 16)


        {



            Turn_Off_TorchScript TurnOff = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

            TurnOff.enabled = true;


            Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            B_Light.enabled = false;


            Stun_Light_Liban G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

            G_Light.enabled = false;


            print("yoyoyoyo");





        }


        if (PowerUpTimer <= 10)


        {

           




            GameObject[] playershoess = GameObject.FindGameObjectsWithTag("Boot");


            foreach (GameObject gos in playershoess)

            {

                gos.GetComponent<Turn_Off_TorchScript>().enabled = false;


            }



            print("gogogogogoo");
        }







        if (PowerUpTimer <= 8 && GameObject.Find("newPlayer").GetComponent<LemarMovment>().Speed > 15 || GameObject.Find("newPlayer").GetComponent<LemarMovment>().Speed < 15)


        {



            LemarMovment spspsp = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            spspsp.Walk = 15;





            print("ioioioiioio");





        }

    
        //cooldown

        if (PowerUpTimer <= 6)


        {

          //  print("ioioioiioio");


            //  this.gameObject.SetActive(false);


            this.gameObject.GetComponent<MeshCollider>().enabled = false;



            Light_Hold_Blue B_Light2 = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            B_Light2.enabled = true;





            Stun_Light_Liban G_Light2 = GameObject.Find("torcia").GetComponent<Stun_Light_Liban>();

            G_Light2.enabled = true;





            Battery_Level Batteryyeah2 = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

            Batteryyeah2.enabled = true;



        }






        if (PowerUpTimer <= 1)

        {




            PowerUpTimer = 16;




            print("back up and running yay");





            this.gameObject.GetComponent<MeshCollider>().enabled = true;







            GameObject[] playershoesss = GameObject.FindGameObjectsWithTag("Boot");


            foreach (GameObject gossss in playershoesss)

            {

                gossss.GetComponent<New_SpeedBoost_Script_Liban>().enabled = false;

                gossss.GetComponent<New_SlowDownScriptBoot_Liban>().enabled = false;


            }


        }




    }





}


    


    




    