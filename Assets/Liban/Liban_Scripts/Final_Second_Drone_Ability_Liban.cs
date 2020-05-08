using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_Second_Drone_Ability_Liban : MonoBehaviour
{


    public GameObject TheDroneYH;


    public static bool expose;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetMouseButtonDown(1))


        {


            expose = true;




            TheDroneYH.GetComponent<SphereCollider>().radius = 8500;

            // TheDroneYH.GetComponent<BoxCollider>().enabled = false;



            Drone_Exposing_Enemies_Liban FGH = GameObject.FindWithTag("Dronee").GetComponent<Drone_Exposing_Enemies_Liban>();

            FGH.enabled = true;





        }


    }



}





          //  TheDroneYH.GetComponent<SphereCollider>().radius = 521.5f;


  