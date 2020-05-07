using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_NewPowerUP_Script_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        


        New_SlowDownScriptBoot_Liban SLOSLOSLO = GameObject.Find("Boot Skin").GetComponent<New_SlowDownScriptBoot_Liban>();

        SLOSLOSLO.enabled = true;




        GetComponent<Turn_Off_TorchScript>().enabled = true;



        GetComponent<Final_SpeedBoost_Timer_Liban>().enabled = true;




        }


        
    
}
