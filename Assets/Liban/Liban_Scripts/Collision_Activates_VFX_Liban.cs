using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Activates_VFX_Liban : MonoBehaviour
{


    public ParticleSystem SmokeySmokey;

    public ParticleSystem ExplosionExplosion;


    public GameObject TheeeeGrenadeyh;

   // private float RespawnTimeAfterExplosion;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "Ground")


        {

            print("yeahyeah");



            SmokeySmokey.gameObject.SetActive(true);



            ExplosionExplosion.gameObject.SetActive(true);



          //  TheeeeGrenadeyh.GetComponent<SphereCollider>().radius = 5.7f;



        }

    }

}





 