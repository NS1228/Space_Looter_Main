using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITD_Exposee_Enemies_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {



        if (other.CompareTag("AI"))

        {





            print("hmmmmm");




             Outline OT5 = GameObject.FindWithTag("AI").GetComponent<Outline>();


             OT5.enabled = true;



            

            



        }





    }







    void OnTriggerExit(Collider other)

    {


        if (other.CompareTag("ExposeEnemy"))


        {



            


            other.GetComponent<Outline>().enabled = false;



        }


    }
}