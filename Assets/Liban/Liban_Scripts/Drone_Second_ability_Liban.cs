using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Second_ability_Liban : MonoBehaviour 
{
    
    public GameObject AmazingDrone;

    public static bool expose;



    // public SphereCollider ColliderForSecondAbility;


    //  public SphereCollider ColliderForFirstAbility;






    void Update()
    {


        if (Input.GetMouseButtonDown(1))

        {


            StartCoroutine(ActivateExposeLocationss());


        }




    }






    IEnumerator ActivateExposeLocationss()



    {



      

        expose = true;


        Drone_Second_ability_Liban XCV = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


        XCV.enabled = true;





        






       ActivateWatchAbilityTwo_Liban AWQ123 = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();


        AWQ123.enabled = false;





      

         AmazingDrone.GetComponent<SphereCollider>().radius = 8499;




         AmazingDrone.GetComponent<SphereCollider>().enabled = true;





        AmazingDrone.GetComponent<BoxCollider>().enabled = false;









        Drone_Exposing_Enemies_Liban EXXXLiban = GameObject.Find("Drone Skin").GetComponent<Drone_Exposing_Enemies_Liban>();


        EXXXLiban.enabled = true;









        //Nil_FOVdetection.droneIntel = true;










        //cancels out ability


        yield return new WaitForSeconds(5.0f);




        expose = false;




        //  Outline O12 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();


        //  O12.enabled = false;






        //   Outline O13 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


        //   O13.enabled = false;





        //  Outline O14 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


        //   O14.enabled = false;



        















        //   AmazingDrone.GetComponent<SphereCollider>().radius = 521.5f;











        //  AmazingDrone.GetComponent<SphereCollider>().enabled = false;









        //Nil_FOVdetection.droneIntel = false;












        yield return new WaitForSeconds(5.7f);











        ActivateWatchAbilityTwo_Liban TGB = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

        TGB.enabled = true;
















    }



}
