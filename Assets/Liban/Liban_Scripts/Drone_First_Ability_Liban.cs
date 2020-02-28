using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drone_First_Ability_Liban : MonoBehaviour
{


    public Transform ThaaaEnemyy;

    public Text EnemyFrozenText;





    void Update()
    {




        if(Input.GetMouseButtonDown(0))


        {


            StartCoroutine(StartTheFirstAbility());



        }



        
    }




    IEnumerator StartTheFirstAbility()


    {


        ThaaaEnemyy.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;




        ActivateWatchAbility ERT = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        ERT.enabled = false;








        Light_Hold_Blue JKL = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();


        JKL.enabled = false;






        Drone_First_Ability_Liban F2367 = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();


        F2367.enabled = false;




        EnemyFrozenText.gameObject.SetActive(true);






        yield return new WaitForSeconds(5.0f);







        ThaaaEnemyy.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;





        ActivateWatchAbility TYU = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();


        TYU.enabled = true;








        EnemyFrozenText.gameObject.SetActive(false);









        yield return new WaitForSeconds(5.5f);








        Drone_First_Ability_Liban PDFG = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();

        PDFG.enabled = true;








        Light_Hold_Blue QAS = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();


        QAS.enabled = true;





    }







}
