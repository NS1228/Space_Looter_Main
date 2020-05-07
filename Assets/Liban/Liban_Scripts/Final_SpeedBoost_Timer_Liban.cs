using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_SpeedBoost_Timer_Liban : MonoBehaviour
{



    public float NewPowerUpTimer = 16.0f;










    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




        NewPowerUpTimer -= Time.deltaTime;




        int secondsss = (int)(NewPowerUpTimer % 60);









        if (NewPowerUpTimer <= 16)


        {


            print("Timer is on");


        }


















        if(NewPowerUpTimer < 8 && GameObject.Find("newPlayer").GetComponent<LemarMovment>().Speed != 15)

        {

            print("time is up yhyhyhyh");



            LemarMovment LMFInal = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            LMFInal.Walk = 15;



           // GetComponent<New_SlowDownScriptBoot_Liban>().enabled = false;

            GetComponent<Turn_Off_TorchScript>().enabled = false;




            New_SlowDownScriptBoot_Liban SLL3 = GameObject.FindWithTag("Boot").GetComponent<New_SlowDownScriptBoot_Liban>();

            SLL3.enabled = false;




            GetComponent<Activate_NewPowerUP_Script_Liban>().enabled = false;






        }







        if(NewPowerUpTimer < 1)


        {




            GetComponent<Final_SpeedBoost_Timer_Liban>().enabled = false;


            print("done");


            NewPowerUpTimer = 16;

        }


















        if(NewPowerUpTimer == 7.9f)

        {






            //  New_SlowDownScriptBoot_Liban SLL = GameObject.Find("newPlayer").GetComponent<New_SlowDownScriptBoot_Liban>();

            //  SLL.enabled = false;


            print("hey");




            LemarMovment LMFInal = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            LMFInal.Walk = 15;



        }











        
    }
}
