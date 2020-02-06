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

    private void Update()
    {


        ThrowObject();

    }

    private void ThrowObject()

    {

        if (HandIsEmpty == false && Input.GetKeyDown(KeyCode.N) && frameReset == false)

        {

            HandIsEmpty = true;

            objectInHand.GetComponent<Rigidbody>().AddForce(Vector3.forward * 800);

            objectInHand.transform.SetParent(null);

            objectInHand.GetComponent<Rigidbody>().useGravity = true;

            print("goodbye");

        }

        if (frameReset == true)

        {


            frameReset = false;

        }
    }



    private void OnTriggerStay(Collider other)
    {


        if (other.CompareTag("PickUpObject") && Input.GetKeyDown(KeyCode.N) && HandIsEmpty == true)

        {

            HandIsEmpty = false;

            frameReset = true;

            other.GetComponent<Rigidbody>().useGravity = false;

            other.transform.SetParent(transform);

            objectInHand = other.gameObject;

            print("yoyo");

            StartCoroutine(PressButtonToYEAH());


        }

    

    }



    IEnumerator PressButtonToYEAH()


    {


        PressN.gameObject.SetActive(true);


        yield return new WaitForSeconds(2.5f);

        PressN.gameObject.SetActive(false);


    }
}


