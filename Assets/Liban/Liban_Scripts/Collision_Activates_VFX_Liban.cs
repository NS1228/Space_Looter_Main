using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Activates_VFX_Liban : MonoBehaviour
{


    public ParticleSystem SmokeySmokey;

    public ParticleSystem ExplosionExplosion;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {


        if(other.gameObject.tag == "TheCursor")


        {

            print("yeahyeah");



            SmokeySmokey.gameObject.SetActive(true);



            ExplosionExplosion.gameObject.SetActive(true);



        }



    }
}
