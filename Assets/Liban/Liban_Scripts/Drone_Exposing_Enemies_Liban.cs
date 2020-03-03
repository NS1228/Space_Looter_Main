using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Exposing_Enemies_Liban : MonoBehaviour
{


    public SphereCollider Spherecolforexposing;



    void OnTriggerEnter (Collider other)
    {



        if(other.CompareTag("AI") && Drone_Second_ability_Liban.expose)


        {


            Outline OL1 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();


            OL1.enabled = true;




            Outline OL2 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


            OL2.enabled = true;



            Outline OL3 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


            OL3.enabled = true;



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


            Outline OL1 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();


            OL1.enabled = false;




            Outline OL2 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


            OL2.enabled = false;




            Outline OL3 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


            OL3.enabled = false;

            Outline OL4 = GameObject.Find("Basicenemy").GetComponent<Outline>();


            OL4.enabled = false;

            other.gameObject.GetComponent<Nil_FOVdetection>().killDrone = true;
            other.gameObject.GetComponent<Nil_FOVdetection>().droneIntel = true;

        }






    }
}
