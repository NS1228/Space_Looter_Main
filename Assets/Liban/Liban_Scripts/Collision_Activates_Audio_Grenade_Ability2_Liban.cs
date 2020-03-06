using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Collision_Activates_Audio_Grenade_Ability2_Liban : MonoBehaviour
{


    public GameObject TheSecondGrenade;


    public AudioSource WoahGoku;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {




        if(other.gameObject.tag == ("TheCursor"))



         {

            print("certain yeahyeah");




            TheSecondGrenade.GetComponent<AudioSource>().minDistance = 7.5f;



            WoahGoku.Play();








        }



        
    }
}
