using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AttachToWall_Liban : MonoBehaviour
{


    public GameObject ElecDevice;


    public AudioSource ElecAudioyh;


    // private GameObject[] ManyObjects;


    public Transform BackToPositionSpawn;

    public GameObject Player;
    void Start()
    {
        ElecDevice.transform.position = BackToPositionSpawn.transform.position;
    }

    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {






        if (other.CompareTag("Wall"))


        {




            ElecDevice.transform.SetParent(null);





            ITD_TimerScript_Liban ITDITD = GameObject.FindWithTag("ITDTimer").GetComponent<ITD_TimerScript_Liban>();

            ITDITD.enabled = true;




            print("attached");





            ElecDevice.GetComponent<BoxCollider>().isTrigger = false;







            Final_ExposeEnemies_ITD_Liban FTREW = GameObject.FindWithTag("Final").GetComponent<Final_ExposeEnemies_ITD_Liban>();

            FTREW.enabled = true;




            GameObject[] YHHH6 = GameObject.FindGameObjectsWithTag("FlashLight");


            foreach (GameObject gosere in YHHH6)

            {
                gosere.GetComponent<Stun_Light_Liban>().enabled = false;

            }





            StartCoroutine(ActActElec());




            GameObject[] YHHH = GameObject.FindGameObjectsWithTag("Light");


            foreach(GameObject gosee in YHHH)

            {
                gosee.GetComponent<ITD_StunLight_Liban>().enabled = true;

            }




            



        }




        }








    IEnumerator ActActElec()


    {



   







        ITD_TimerScript_Liban ITDDTIME = GameObject.FindWithTag("ITDTimer").GetComponent<ITD_TimerScript_Liban>();


        ITDDTIME.enabled = true;





        ElecAudioyh.Play();





        ElecAudioyh.loop = true;





       




     //   GameObject [] enemies = GameObject.FindGameObjectsWithTag ("AI");



        //  foreach (GameObject go in enemies)
//

        //  {
          //    go.GetComponent<Outline>().enabled = true;
        //  }















        yield return new WaitForSeconds(6.0f);











        GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("AI");



        foreach (GameObject go in enemies1)

        {

            go.GetComponent<Outline>().enabled = false;


        }




        


        ElecAudioyh.loop = false;



        print("back where it is");




        ElecDevice.transform.position = BackToPositionSpawn.transform.position;
        ElecDevice.transform.parent = Player.transform;



        // Final_ExposeEnemies_ITD_Liban FTREW = GameObject.Find("Expose Enemy Location ITD Device").GetComponent<Final_ExposeEnemies_ITD_Liban>();

        // FTREW.enabled = false;








        yield return new WaitForSeconds(4.0f);




        ElecDevice.GetComponent<BoxCollider>().isTrigger = true;


        print("available to use");




    }





    }




    



 