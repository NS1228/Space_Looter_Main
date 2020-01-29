using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch_Script : MonoBehaviour
{


    public Transform YeahPlayer;

    public GameObject TheWatch;





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




        yield return new WaitForSeconds(3.0f);


        YeahPlayer.GetComponent<MeshRenderer>().enabled = true;


        TheWatch.GetComponent<MeshRenderer>().enabled = true;

       



    }

}
