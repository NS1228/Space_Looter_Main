using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing_Script : MonoBehaviour
{


    public Transform ThrowingPosition;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {




        if(other.CompareTag("Player"))


        {


            transform.position = ThrowingPosition.transform.position;





        }


    }
}
