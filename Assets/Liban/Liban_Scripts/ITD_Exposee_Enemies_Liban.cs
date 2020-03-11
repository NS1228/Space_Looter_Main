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



        if (other.CompareTag("ExposeEnemy"))

        {



            Outline OTY5 = GameObject.Find("Cylinder3").GetComponent<Outline>();


            OTY5.enabled = true;



            print("hmmmmm");



        }





    }







    void OnTriggerExit(Collider other)

    {


        if (other.CompareTag("ExposeEnemy"))


        {


            Outline OTY7 = GameObject.Find("Cylinder3").GetComponent<Outline>();


            OTY7.enabled = false;






        }


    }
}