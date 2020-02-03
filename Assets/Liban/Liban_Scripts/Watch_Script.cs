using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Watch_Script : MonoBehaviour
{


    public GameObject YeahPlayer;

    public GameObject TheWatch;

    public Transform CloningPoint;

    public GameObject FakeYeahPlayer;

    public ParticleSystem SmokeYEAH;


    void OnTriggerEnter (Collider other)


    {



        if (other.CompareTag ("Player"))


        {


            StartCoroutine(InvisibleYEAH(other));


        }



        
    }






    IEnumerator InvisibleYEAH (Collider player)



    {



        YeahPlayer.GetComponent<MeshRenderer>().enabled = false;

        TheWatch.GetComponent<MeshRenderer>().enabled = false;

        GameObject CLO = Instantiate(FakeYeahPlayer, CloningPoint.position, CloningPoint.rotation);

        SmokeYEAH.gameObject.SetActive(true);


        yield return new WaitForSeconds(5.0f);


        YeahPlayer.GetComponent<MeshRenderer>().enabled = true;


        TheWatch.GetComponent<MeshRenderer>().enabled = true;


        Destroy(CLO);


       



    }

}
