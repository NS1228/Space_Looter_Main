using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Col_Activate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {


        if(other.gameObject.name == "Object Collider for exposing enemies")


        {



            Outline OL = GameObject.FindWithTag("yo").GetComponent<Outline>();


            OL.enabled = true;



            print("poooooo");





        }






    }
}
