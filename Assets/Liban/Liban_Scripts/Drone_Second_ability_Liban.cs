using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Second_ability_Liban : MonoBehaviour
{
    



    void Update()
    {
        

        if(Input.GetMouseButtonDown(1))

        {


            StartCoroutine(ActivateExposeLocations());


        }




    }






    IEnumerator ActivateExposeLocations()



    {



        Outline O1 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();

        O1.enabled = true;






        Outline O2 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


        O2.enabled = true;





        Outline O3 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


        O3.enabled = true;





        Drone_Second_ability_Liban XCV = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


        XCV.enabled = false;





        Stun_Light_Liban Stunnnn = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();


        Stunnnn.enabled = false;






        ActivateWatchAbilityTwo_Liban AWQ123 = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();


        AWQ123.enabled = false;









        yield return new WaitForSeconds(5.0f);











        Outline O12 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();


        O12.enabled = false;






        Outline O13 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();


        O13.enabled = false;






        Outline O14 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();


        O14.enabled = false;









        Stun_Light_Liban Stttttun = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();


        Stttttun.enabled = true;











        yield return new WaitForSeconds(5.7f);







        Drone_Second_ability_Liban ZXC = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


        ZXC.enabled = true;








        ActivateWatchAbilityTwo_Liban TGB = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

        TGB.enabled = true;
















    }



}
