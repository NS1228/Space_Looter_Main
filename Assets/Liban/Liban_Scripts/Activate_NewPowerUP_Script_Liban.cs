using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_NewPowerUP_Script_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {

        if(other.CompareTag("Player"))


        {



            New_SpeedBoost_Script_Liban POLPOLPOL = GameObject.Find("Boot Skin").GetComponent<New_SpeedBoost_Script_Liban>();


            POLPOLPOL.enabled = true;


        }


        
    }
}
