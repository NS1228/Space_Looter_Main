﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_NewPowerUP_Script_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        New_SpeedBoost_Script_Liban POLPOLPOL = GameObject.Find("Boot Skin").GetComponent<New_SpeedBoost_Script_Liban>();


        POLPOLPOL.enabled = true;




        New_SlowDownScriptBoot_Liban SLOSLOSLO = GameObject.Find("Boot Skin").GetComponent<New_SlowDownScriptBoot_Liban>();

        SLOSLOSLO.enabled = true;
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {

        if(other.CompareTag("Player"))


        {



            New_SpeedBoost_Script_Liban POLPOLPOL = GameObject.Find("Boot Skin").GetComponent<New_SpeedBoost_Script_Liban>();


            POLPOLPOL.enabled = true;




            New_SlowDownScriptBoot_Liban SLOSLOSLO = GameObject.Find("Boot Skin").GetComponent<New_SlowDownScriptBoot_Liban>();

            SLOSLOSLO.enabled = true;


        }


        
    }
}
