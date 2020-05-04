using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_First_Ability_Drone_Liban : MonoBehaviour
{

    public GameObject TheDronee;



    //new size

    private float SizeX = 15000;

    private float SizeY = 15000;

    private float SizeZ = 15000;




    //original size


    private float OSizeX = 830.96f;

    private float OSizeY = 725.79f;

    private float OSizeZ = 948.64f;

    public static bool freeze;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))


        {
            print("lo");


            StartCoroutine(OneAbility());

        }







        IEnumerator OneAbility()


        {

            freeze = true;




          



            TheDronee.GetComponent<BoxCollider>().size = new Vector3(SizeX, SizeY, SizeZ);








            yield return new WaitForSeconds(7.0f);





            

            TheDronee.GetComponent<BoxCollider>().size = new Vector3(OSizeX, OSizeY, OSizeZ);




            freeze = false;





            Final_First_Ability_Drone_Liban POI = GameObject.Find("Activate Drone First Ability").GetComponent<Final_First_Ability_Drone_Liban>();

            POI.enabled = false;










            yield return new WaitForSeconds(4.0f);





            Final_First_Ability_Drone_Liban POI2 = GameObject.Find("Activate Drone First Ability").GetComponent<Final_First_Ability_Drone_Liban>();

            POI2.enabled = true;




        }

    }
}