using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Off_TorchScript : MonoBehaviour
{

    public float SpeedBoost = 5.5f;

    public Transform ThePlayer;

    public GameObject CrawlSound;

    public GameObject RunSound;

    public GameObject WalkSound;

    

    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {






        // change back to Getmousebutton if doesnt work 

        if (Input.GetMouseButtonDown(0))


        {






            print("faster faster...");





            // Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            //  B_Light.enabled = false;








            LemarMovment LMoving1 = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            LMoving1.Walk += SpeedBoost;




            RunSound.GetComponent<AudioSource>().maxDistance = 8.0f;

            WalkSound.GetComponent<AudioSource>().maxDistance = 8.0f;

            CrawlSound.GetComponent<AudioSource>().maxDistance = 8.0f;




        }





        if (Input.GetMouseButtonUp(0))


        {



          //  Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

           // B_Light.enabled = true;


            // Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

            //  G_Light.enabled = true;



            LemarMovment LMoving = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            LMoving.Walk -= SpeedBoost;




            RunSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            WalkSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            CrawlSound.GetComponent<AudioSource>().maxDistance = 1.05f;







        }








        }





    }






















    

