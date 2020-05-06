using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_SlowDownScriptBoot_Liban : MonoBehaviour
{
    public float Slowerrrboost = 5f;

    public Transform ThePlayeeer;

    public GameObject CrawlllSound;

    public GameObject RunnnSound;

    public GameObject WalkkkSound;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetMouseButtonDown(1))


        {



           


             LemarMovment LMoving3 = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

              LMoving3.Walk -= 5;




            print("slower slower...");




        //    RunnnSound.GetComponent<AudioSource>().maxDistance = 0f;

         //   WalkkkSound.GetComponent<AudioSource>().maxDistance = 0f;
         //
          //  CrawlllSound.GetComponent<AudioSource>().maxDistance = 0f;



        }





        if (Input.GetMouseButtonUp(1))



        {

            


            LemarMovment LMoving4 = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            LMoving4.Walk += 5f;

            


          //  RunnnSound.GetComponent<AudioSource>().maxDistance = 1.05f;

          //  WalkkkSound.GetComponent<AudioSource>().maxDistance = 1.05f;

          //  CrawlllSound.GetComponent<AudioSource>().maxDistance = 1.05f;



        }
    }
}