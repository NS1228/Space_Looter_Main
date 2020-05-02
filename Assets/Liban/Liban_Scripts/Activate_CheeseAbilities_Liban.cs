using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_CheeseAbilities_Liban : MonoBehaviour
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

            GetComponent<Cheese_Gunk_Liban>().enabled = true;


            GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;


            GetComponent<Stun_Light_Liban>().enabled = false;


            GetComponent<Light_Hold_Blue>().enabled = false;

        }


        
    }
}
