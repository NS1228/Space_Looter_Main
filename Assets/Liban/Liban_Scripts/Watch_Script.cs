using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Watch_Script : MonoBehaviour
{


    public GameObject YeahPlayer;

    public GameObject Face;

    public GameObject TheWatch;

    public Transform CloningPoint1;

    public Transform CloningPoint2;

    public Transform CloningPoint3;

   // public Transform CloningPoint4;

    public GameObject FakeYeahPlayer;

    public ParticleSystem SmokeYEAH;

    public AudioSource Sike;


    void OnTriggerEnter (Collider other)


    {



        if (other.CompareTag ("Player"))


        {


            StartCoroutine(InvisibleYEAH(other));


        }



        
    }






    IEnumerator InvisibleYEAH (Collider player)



    {

        Sike.Play();

        YeahPlayer.GetComponent<MeshRenderer>().enabled = false;

        Face.GetComponent<MeshRenderer>().enabled = false;

        TheWatch.GetComponent<MeshRenderer>().enabled = false;

        TheWatch.GetComponent<BoxCollider>().enabled = false;

        GameObject CLO = Instantiate(FakeYeahPlayer, CloningPoint1.position, CloningPoint1.rotation);

        GameObject CLO2 = Instantiate(FakeYeahPlayer, CloningPoint2.position, CloningPoint2.rotation);

        GameObject CLO3 = Instantiate(FakeYeahPlayer, CloningPoint3.position, CloningPoint3.rotation);
        

        SmokeYEAH.gameObject.SetActive(true);


        yield return new WaitForSeconds(3.0f);


        YeahPlayer.GetComponent<MeshRenderer>().enabled = true;


        TheWatch.GetComponent<MeshRenderer>().enabled = true;


        TheWatch.GetComponent<BoxCollider>().enabled = true;


        Face.GetComponent<MeshRenderer>().enabled = true;


        Destroy(CLO);

        Destroy(CLO2);

        Destroy(CLO3); 


       



    }

}
