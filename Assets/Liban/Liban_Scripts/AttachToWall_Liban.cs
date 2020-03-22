﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AttachToWall_Liban : MonoBehaviour
{


    public GameObject ElecDevice;


    public AudioSource ElecAudioyh;


   // private GameObject[] ManyObjects;




    void OnTriggerEnter(Collider other)
    {






        if (other.CompareTag("Wall"))


        {




            ElecDevice.transform.SetParent(null);





            ITD_TimerScript_Liban ITDITD = GameObject.FindWithTag("ITDTimer").GetComponent<ITD_TimerScript_Liban>();

            ITDITD.enabled = true;




            print("attached");





            ElecDevice.GetComponent<BoxCollider>().isTrigger = false;





            //try a startcoroutine here


            //below the coroutine, turn on the outline scripts and turn off the IT_exposee_enemiesLiban as that script doesn't work for some reason  




            StartCoroutine(ActActElec());

            


        }




        }








    IEnumerator ActActElec()


    {



        yield return new WaitForSeconds(2.0f);







        ITD_TimerScript_Liban ITDDTIME = GameObject.FindWithTag("ITDTimer").GetComponent<ITD_TimerScript_Liban>();


        ITDDTIME.enabled = true;





        ElecAudioyh.Play();





        ElecAudioyh.loop = true;





       




        GameObject [] enemies = GameObject.FindGameObjectsWithTag ("AI");



          foreach (GameObject go in enemies)


          {
              go.GetComponent<Outline>().enabled = true;
          }















        yield return new WaitForSeconds(9.0f);











        GameObject[] enemies1 = GameObject.FindGameObjectsWithTag("AI");



        foreach (GameObject go in enemies1)

        {

            go.GetComponent<Outline>().enabled = false;


        }







        ElecAudioyh.loop = false;



        print("yhyh");




    }





    }




    



 