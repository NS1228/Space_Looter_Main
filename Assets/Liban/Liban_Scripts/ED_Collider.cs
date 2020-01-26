using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED_Collider : MonoBehaviour
{


    public GameObject ElecDevice;


    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {


        if(other.CompareTag("Player"))


        {


            Outline OUTLINERYEAH = GameObject.Find("enemy sphere").GetComponent<Outline>();

            OUTLINERYEAH.enabled = true;


            ElecDevice.SetActive(false);


        }

        
    }
}
