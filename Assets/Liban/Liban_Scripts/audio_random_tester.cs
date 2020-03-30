using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class audio_random_tester : MonoBehaviour
{

    public AudioClip [] B3;

    public AudioSource B2;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.P))

        {


            B2.clip = B3[Random.Range(0, B3.Length)];


            B2.Play();


        }

        
    }
}
