using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class testing_audio_collider_liban : MonoBehaviour
{


    
    public GameObject cubeeeee;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTrigggerEnter (Collider other)
    {





        if(other.CompareTag("yo"))


        {


            Outline yhyh = GameObject.FindWithTag("yo").GetComponent<Outline>();

            yhyh.enabled = true;


            print("lolol");



        }

        
    }
}
