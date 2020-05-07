using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_SpeedBoost_Timer_Liban : MonoBehaviour
{



    public float NewPowerUpTimer = 16.0f;



    public Text PowerEnabledTextt;






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






        if(NewPowerUpTimer < 12)

        {
            PowerEnabledTextt.gameObject.SetActive(false);

        }











        if(NewPowerUpTimer < 8 && GameObject.Find("FinalPlayer").GetComponent<LemarMovment>().Speed != 15)

        {

            print("time is up!!!");



            LemarMovment LMFInal = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

            LMFInal.Walk = 15;



            // GetComponent<New_SlowDownScriptBoot_Liban>().enabled = false;

            Turn_Off_TorchScript FST7 = GameObject.FindWithTag("Boot").GetComponent<Turn_Off_TorchScript>();

            FST7.enabled = false;

            FST7.CTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            FST7.CVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            FST7.RTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            FST7.RVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            FST7.WVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            FST7.WTrigger.transform.localScale = new Vector3(1f, 1f, 1f);




            New_SlowDownScriptBoot_Liban SLL3 = GameObject.FindWithTag("Boot").GetComponent<New_SlowDownScriptBoot_Liban>();

            SLL3.enabled = false;

            SLL3.CTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            SLL3.CVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            SLL3.RTrigger.transform.localScale = new Vector3(1f, 1f, 1f);

            SLL3.RVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            SLL3.WVisual.transform.localScale = new Vector3(1f, 1f, 1f);

            SLL3.WTrigger.transform.localScale = new Vector3(1f, 1f, 1f);






            GetComponent<Activate_NewPowerUP_Script_Liban>().enabled = false;



            

            



        }









        if(NewPowerUpTimer < 8)


        {



            LemarMovment LMFInal5 = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

            LMFInal5.Walk = 15;


            GetComponent<Turn_Off_TorchScript>().enabled = false;




            New_SlowDownScriptBoot_Liban SLL3 = GameObject.FindWithTag("Boot").GetComponent<New_SlowDownScriptBoot_Liban>();

            SLL3.enabled = false;




            GetComponent<Activate_NewPowerUP_Script_Liban>().enabled = false;



            print("timer up!");


        }








        if (NewPowerUpTimer < 1)


        {



            GetComponent<Activate_NewPowerUP_Script_Liban>().enabled = true;


            GetComponent<Final_SpeedBoost_Timer_Liban>().enabled = false;


            print("timer done and power up done, Press 'O' to restart gadget");


            NewPowerUpTimer = 16;

        }


















        if(NewPowerUpTimer == 7.9f)

        {






            //  New_SlowDownScriptBoot_Liban SLL = GameObject.Find("newPlayer").GetComponent<New_SlowDownScriptBoot_Liban>();

            //  SLL.enabled = false;


            print("hey");




            LemarMovment LMFInal = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

            LMFInal.Walk = 15;



        }











        
    }
}
