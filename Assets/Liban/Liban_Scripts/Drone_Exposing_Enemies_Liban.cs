using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Exposing_Enemies_Liban : MonoBehaviour
{


    public SphereCollider Spherecolforexposing;



    void OnTriggerEnter (Collider other)
    {



        if(other.CompareTag("AI") && Final_Second_Drone_Ability_Liban.expose)


        {


            Outline YOU = GameObject.FindGameObjectWithTag("AI").GetComponent<Outline>();

            YOU.enabled = true;



            Outline OL4 = GameObject.Find("Basicenemy").GetComponent<Outline>();


            OL4.enabled = true;


            other.gameObject.GetComponent<Nil_FOVdetection>().killDrone = true;
            other.gameObject.GetComponent<Nil_FOVdetection>().droneIntel = true;







        }


    }






     void OnTriggerExit(Collider other)


    {



        if (other.CompareTag("AI"))


        {


            GameObject[] exposeeee = GameObject.FindGameObjectsWithTag("AI");

            foreach (GameObject gogogo in exposeeee)

            {

                gogogo.GetComponent<Outline>().enabled = false;

            }








            Outline OL4 = GameObject.Find("Basicenemy").GetComponent<Outline>();


            OL4.enabled = false;

            other.gameObject.GetComponent<Nil_FOVdetection>().killDrone = true;
            other.gameObject.GetComponent<Nil_FOVdetection>().droneIntel = true;

        }






    }
}
