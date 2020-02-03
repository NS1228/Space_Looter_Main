using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing_Script : MonoBehaviour
{


   // public Transform ThrowingPosition;

    public bool HandIsEmpty = true;

    private GameObject objectInHand;

    private bool frameReset = false;




    private void ThrowObject()

    {

        if (HandIsEmpty == false && Input.GetKeyDown(KeyCode.N) && frameReset == false)

        {

            HandIsEmpty = true;

            objectInHand.GetComponent<Rigidbody>().AddForce(Vector3.forward * 1500);

            objectInHand.transform.SetParent(null);

            objectInHand.GetComponent<Rigidbody>().useGravity = true;

        }

        if (frameReset == true)

        {


            frameReset = false;

        }
    }



    private void OnTriggerStay(Collider other)
    {


        if(other.CompareTag("PickUpObject") && Input.GetKeyDown(KeyCode.N) && HandIsEmpty == true)

        {

            HandIsEmpty = false;

            frameReset = true;

            other.GetComponent<Rigidbody>().useGravity = false;

            other.transform.SetParent(transform);

            objectInHand = other.gameObject;



        }



    }









}
