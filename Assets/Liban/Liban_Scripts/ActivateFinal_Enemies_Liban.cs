using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFinal_Enemies_Liban : MonoBehaviour
{




    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("AI"))

        {


            print("loplop");



            GameObject[] enemies = GameObject.FindGameObjectsWithTag("AI");



            foreach (GameObject go in enemies)

            {

                go.GetComponent<Outline>().enabled = true;


            }


        }



    }


}