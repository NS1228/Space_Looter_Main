using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Freezing_Enemies : MonoBehaviour
{



    public BoxCollider BoxColliderAbilityyh;

   // public Transform ThaaaaEnemy;

   // public Transform ThaaaaEnemy2;




    void OnTriggerEnter (Collider other)
    {



        if ( other.CompareTag("AI") && Drone_First_Ability_Liban.freeze)


        {

            //  ThaaaaEnemy.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            other.gameObject.GetComponent<Nil_FOVdetection>().killDrone = true;
            other.gameObject.GetComponent<Nil_FOVdetection>().immobilosingRipple = true;


           // ThaaaaEnemy2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;

       

        }



    }

}



