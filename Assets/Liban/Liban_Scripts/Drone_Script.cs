using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Script : MonoBehaviour
{


    public Transform Enemyyeah;



    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))


        {


            StartCoroutine(FreezeEnemy(other));



        }


    }




    IEnumerator FreezeEnemy(Collider player)




    {



        Enemyyeah.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ; 


        yield return new WaitForSeconds(2.0f);


        Enemyyeah.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;




    }
}

