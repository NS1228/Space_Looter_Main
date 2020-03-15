using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToWall_Liban : MonoBehaviour
{


    public GameObject ElecDevice;

    





    void OnTriggerEnter(Collider other)
    {






        if (other.CompareTag("Wall"))


        {




            ElecDevice.transform.SetParent(null);





        //    ITD_TimerScript_Liban ITDITD = GameObject.FindWithTag("ITDTimer").GetComponent<ITD_TimerScript_Liban>();

          //  ITDITD.enabled = true;




            //   ElecDevice.GetComponent<SphereCollider>().enabled = false;




            ElecDevice.GetComponent<BoxCollider>().isTrigger = false;


            



            //try a startcoroutine here


            //below the coroutine, turn on the outline scripts and turn off the IT_exposee_enemiesLiban as that script doesn't work for some reason  




            StartCoroutine(ActActElec());

            


        }




        }








    IEnumerator ActActElec()


    {






        ITD_TimerScript_Liban ITDDTIME = GameObject.FindWithTag("ITDTimer").GetComponent<ITD_TimerScript_Liban>();


        ITDDTIME.enabled = true;

       





        yield return new WaitForSeconds(5.0f);






        print("hello");
     




    }





    }




    



 