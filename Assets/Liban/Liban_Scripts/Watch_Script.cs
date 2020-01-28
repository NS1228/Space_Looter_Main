using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch_Script : MonoBehaviour
{


    public Transform YeahPlayer;

    public GameObject TheWatch;

    public GameObject TheWatch2;

    public GameObject TheWatch3;




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

        TheWatch2.GetComponent<MeshRenderer>().enabled = false;

        TheWatch3.GetComponent<MeshRenderer>().enabled = false;



        yield return new WaitForSeconds(2.0f);


        YeahPlayer.GetComponent<MeshRenderer>().enabled = true;


        TheWatch.GetComponent<MeshRenderer>().enabled = true;

        TheWatch2.GetComponent<MeshRenderer>().enabled = true;

        TheWatch3.GetComponent<MeshRenderer>().enabled = true;




    }

}
