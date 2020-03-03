using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Freezing_Enemies : MonoBehaviour
{



    public BoxCollider BoxColliderAbilityyh;

    public Transform ThaaaaEnemy;

    public Transform ThaaaaEnemy2;




    void OnTriggerEnter (Collider other)
    {



        if ( other.CompareTag("AI"))


        {

            ThaaaaEnemy.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;



            ThaaaaEnemy2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;


        }



    }

}



