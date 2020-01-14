using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{


    public GameObject Shoes;


    // Update is called once per frame
    void OnTriggerEnter (Collider other)

    {

        if(other.CompareTag("Player"))

        {

            Shoes.gameObject.SetActive(true); 


        }

        
    }
}
