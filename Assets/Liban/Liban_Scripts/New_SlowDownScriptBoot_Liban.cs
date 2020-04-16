using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_SlowDownScriptBoot_Liban : MonoBehaviour
{
    private float Slowerrrboost = 5.5f;

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


        if (Input.GetMouseButton(1))


        {

            


            Battery_Level Batteryyeah = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

            Batteryyeah.enabled = false;


            print("slower slower...");


             LemarMovment LMoving2 = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

              LMoving2.Walk -= 5.5f;



         //   GameObject[] slowerslower = GameObject.FindGameObjectsWithTag("Player");

          //  foreach (GameObject plpl in slowerslower)

          //  {
           //     plpl.GetComponent<LemarMovment>().Speed -= Slowerrrboost;

          //  }





            RunnnSound.GetComponent<AudioSource>().maxDistance = 0f;

            WalkkkSound.GetComponent<AudioSource>().maxDistance = 0f;

            CrawlllSound.GetComponent<AudioSource>().maxDistance = 0f;



        }





        if (Input.GetMouseButtonUp(1))



        {

            


            LemarMovment LMoving = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            LMoving.Walk = 15;

            


            RunnnSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            WalkkkSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            CrawlllSound.GetComponent<AudioSource>().maxDistance = 1.05f;



        }
    }
}