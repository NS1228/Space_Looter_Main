using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Collision_Activates_Audio_Grenade_Ability2_Liban : MonoBehaviour
{


    public GameObject TheSecondGrenade;


    public AudioSource WoahGoku;


    public GameObject ChildAudioStun;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter (Collision other)
    {




        if(other.gameObject.tag == ("Ground"))



         {

            print("certain yeahyeah");




            TheSecondGrenade.GetComponent<AudioSource>().minDistance = 7.5f;



            WoahGoku.Play();




            ChildAudioStun.gameObject.SetActive(true);

            ChildAudioStun.GetComponent<SphereCollider>().radius = 7.5f;


            ChildAudioStun.GetComponent<SphereCollider>().enabled = true;



           


        }



        
    }
}
