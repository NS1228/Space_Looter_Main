﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drone_First_Ability_Liban : MonoBehaviour
{


    public Transform ThaaaEnemyy;

    public Text EnemyFrozenText;


    public GameObject TheAmazingDrone;



    public Transform DAENEMY1;


    public Transform DAENEMY2;



    //new size

    private float SizeX = 15000.1f;

    private float SizeY = 15000.1f;

    private float SizeZ = 15000.1f;



    //original size


    private float OriginalSizeX = 830.96f;

    private float OriginalSizeY = 725.79f;

    private float OriginalSizeZ = 948.65f;

    public static bool freeze;


    // public SphereCollider ColliderForFirstAbility;


    // public SphereCollider ColliderForSecondAbility; 





    void Update()
    {




        if (Input.GetMouseButtonDown(0))


        {


            StartCoroutine(StartTheFirstAbility());


            print("yo");

        }




    }




    IEnumerator StartTheFirstAbility()


        {






            freeze = true;

            Drone_First_Ability_Liban F2367 = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();


            F2367.enabled = true;









            ActivateWatchAbility ERT = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

            ERT.enabled = false;





            Drone_Second_ability_Liban SECSEC = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


            SECSEC.enabled = false;







            EnemyFrozenText.gameObject.SetActive(true);








            TheAmazingDrone.GetComponent<BoxCollider>().enabled = true;



            TheAmazingDrone.GetComponent<BoxCollider>().size = new Vector3(SizeX, SizeY, SizeZ);










            yield return new WaitForSeconds(10.0f);






            freeze = false;





            ActivateWatchAbility TYU = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();


            TYU.enabled = true;







            TheAmazingDrone.GetComponent<BoxCollider>().size = new Vector3(OriginalSizeX, OriginalSizeY, OriginalSizeZ);






            EnemyFrozenText.gameObject.SetActive(false);





            DAENEMY1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;



            DAENEMY2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;






            Drone_Second_ability_Liban RTY = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


            RTY.enabled = true;










            yield return new WaitForSeconds(5.5f);











            Drone_First_Ability_Liban PDFG = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();

            PDFG.enabled = true;


























        }



    }








