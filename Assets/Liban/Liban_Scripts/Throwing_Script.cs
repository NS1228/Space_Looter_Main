using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwing_Script : MonoBehaviour
{


    // public Transform ThrowingPosition;

    public bool HandIsEmpty = true;

    private GameObject objectInHand;

    private bool frameReset = false;

    public Text PressN;

   

    //for the TheTarget transform, make sure you attach an empty gameobject to the player from far as that would be the target




    //private void Update()
    //{


       // ThrowObject();

  //  }




   // private void ThrowObject()

   // {

       // if (HandIsEmpty == false && Input.GetKeyDown(KeyCode.N) && frameReset == false)

       // {

          //  HandIsEmpty = true;

          //  objectInHand.GetComponent<Rigidbody>().AddForce(Vector3.forward * 800);


          //  objectInHand.transform.SetParent(null);


          //  objectInHand.GetComponent<Rigidbody>().useGravity = true;

           // print("goodbye");

            //Projectile_Donut ProjectileDD = GameObject.FindWithTag("PickUpObject").GetComponent<Projectile_Donut>();

           // ProjectileDD.enabled = true;



        //}

       // if (frameReset == true)

       // {


         //   frameReset = false;

       // }
   // }



  private void OnTriggerStay(Collider other)
  {


      if (other.CompareTag("PickUpObject") && Input.GetKeyDown(KeyCode.N) && HandIsEmpty == true)

      {

          HandIsEmpty = false;

          frameReset = true;

         // other.GetComponent<Rigidbody>().useGravity = false;

          other.transform.SetParent(transform);

          objectInHand = other.gameObject;

          print("LOL");

          StartCoroutine(PressButtonToYEAH());


            other.GetComponent<BoxCollider>().isTrigger = false;


      }



 }



  IEnumerator PressButtonToYEAH()


  {


      PressN.gameObject.SetActive(true);


      yield return new WaitForSeconds(2.5f);


      PressN.gameObject.SetActive(false);


  }
}


