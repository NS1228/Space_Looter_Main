using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Reacting_To_GreenLight_Liban : MonoBehaviour
{



    public static bool SlowingDownEnemy; 


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "AI")

        {
           // print("COLL");
            SlowingDownEnemy = true;


        }


        
    }






     void OnTriggerExit(Collider other)

    {


        if(other.gameObject.tag == "AI")

        {

            //print("OFFCOLL");
            SlowingDownEnemy = false;


        }


    }

}
