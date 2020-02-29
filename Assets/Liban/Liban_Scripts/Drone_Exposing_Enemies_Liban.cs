using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Exposing_Enemies_Liban : MonoBehaviour
{


    public SphereCollider Spherecolforexposing;



    void OnTriggerEnter (Collider other)
    {



        if(other.CompareTag("EnemyDrone"))


        {


            Outline OL1 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();


            OL1.enabled = true;




            Outline OL2 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


            OL2.enabled = true;



            Outline OL3 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


            OL3.enabled = true;





        }


    }






     void OnTriggerExit(Collider other)


    {



        if (other.CompareTag("EnemyDrone"))


        {


            Outline OL1 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();


            OL1.enabled = false;




            Outline OL2 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


            OL2.enabled = false;




            Outline OL3 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


            OL3.enabled = false;

        }






    }
}
