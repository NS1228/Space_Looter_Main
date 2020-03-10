using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToWall_Liban : MonoBehaviour
{


    public GameObject Device;


    // Update is called once per frame
    void OnCollisionEnter (Collision other)
    {


        if(other.gameObject.tag == "Wall")


        {


            

            print("It Stuck");







        }



    }
}
