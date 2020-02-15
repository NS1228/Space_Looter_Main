using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTorchLiban : MonoBehaviour
{

    public GameObject DaTorch;


    void OnTriggerEnter (Collider other)
    {


        if(other.CompareTag("Player"))


        {


            DaTorch.SetActive(true);


            Destroy(gameObject);


        }



    }
}
