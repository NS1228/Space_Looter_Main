using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToWall_Liban : MonoBehaviour
{


    public GameObject Device;


    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {


        if(other.CompareTag("Wall"))


        {


            Device.transform.position = transform.position;

            print("It Stuck");







        }



    }
}
