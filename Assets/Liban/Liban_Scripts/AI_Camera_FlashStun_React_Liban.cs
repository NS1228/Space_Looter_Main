using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Camera_FlashStun_React_Liban : MonoBehaviour
{


    public static bool StunningEnemy = false;


    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {



        if (other.gameObject.tag == "AI")

        {
            // print("COLL");


            StunningEnemy = true;
            other.GetComponent<Nil_FOVdetection>().stunned = true;

        }



    }






}
