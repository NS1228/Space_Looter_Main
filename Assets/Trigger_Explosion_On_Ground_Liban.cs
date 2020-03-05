using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Explosion_On_Ground_Liban : MonoBehaviour
{




    [Header ("Character")]


    public Transform TheGrenadeItself;


    public CharacterController CC_LIBAN;




    [Header ("Particles")]

    public ParticleSystem Sparkyy;

    public ParticleSystem Smokeeee;




    // Start is called before the first frame update
    void Start()
    {




        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {



       // if(other.CompareTag("ground"))




        if(CC_LIBAN.isGrounded)

        {


            // Sparkyy.Play();



            //  Smokeeee.Play();



            Sparkyy.gameObject.SetActive(true);



            Smokeeee.gameObject.SetActive(true);




            print("explode");




      


        }


        
    }
}
