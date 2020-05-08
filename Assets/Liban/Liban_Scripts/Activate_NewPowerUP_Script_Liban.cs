using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Activate_NewPowerUP_Script_Liban : MonoBehaviour
{


    public Text PowerEnabledText;


    // Start is called before the first frame update
    void Update()
    {



        if (Input.GetKey(KeyCode.Z))

        {

            PowerEnabledText.gameObject.SetActive(true);


            New_SlowDownScriptBoot_Liban SLOSLOSLO = GameObject.Find("Boot Skin").GetComponent<New_SlowDownScriptBoot_Liban>();

            SLOSLOSLO.enabled = true;




            GetComponent<Turn_Off_TorchScript>().enabled = true;



            GetComponent<Final_SpeedBoost_Timer_Liban>().enabled = true;



            print("hehe");

        }









    }
}