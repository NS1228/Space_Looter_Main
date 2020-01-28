using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch_Script : MonoBehaviour
{


    public GameObject YeahPlayer;




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

        yield return new WaitForSeconds(2.0f);

        YeahPlayer.GetComponent<MeshRenderer>().enabled = true;





    }

}
