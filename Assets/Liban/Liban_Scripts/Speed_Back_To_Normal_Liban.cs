using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Back_To_Normal_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(GetComponent<LemarMovment>().Speed > 15)

        {


            GetComponent<LemarMovment>().Speed = 15;


            print("oooooo");


        }



        
    }
}
