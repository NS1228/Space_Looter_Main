using System.Collections;
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




   // public SphereCollider ColliderForFirstAbility;


  // public SphereCollider ColliderForSecondAbility; 





    void Update()
    {




        if(Input.GetMouseButtonDown(0))


        {


            StartCoroutine(StartTheFirstAbility());



        }



        
    }




    IEnumerator StartTheFirstAbility()


    {












        Drone_First_Ability_Liban F2367 = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();


        F2367.enabled = true;













        ActivateWatchAbility ERT = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        ERT.enabled = false;














        Light_Hold_Blue JKL = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();


        JKL.enabled = false;










        Nil_FOVdetection.immobilosingRipple = true;









        Drone_Second_ability_Liban SECSEC = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


        SECSEC.enabled = false;







        EnemyFrozenText.gameObject.SetActive(true);




        // TheAmazingDrone.GetComponent<BoxCollider>().enabled = true;






        TheAmazingDrone.GetComponent<BoxCollider>().enabled = true;



        TheAmazingDrone.GetComponent<BoxCollider>().size = new Vector3(SizeX, SizeY, SizeZ);




       // TheAmazingDrone.GetComponent<SphereCollider>().enabled = false;














        yield return new WaitForSeconds(5.0f);







      //  ThaaaEnemyy.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;





        ActivateWatchAbility TYU = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();


        TYU.enabled = true;







        TheAmazingDrone.GetComponent<BoxCollider>().size = new Vector3(OriginalSizeX, OriginalSizeY, OriginalSizeZ);






        EnemyFrozenText.gameObject.SetActive(false);





        DAENEMY1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;



        DAENEMY2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;







        //  ColliderForFirstAbility.enabled = false;




        //  ColliderForSecondAbility.enabled = true;






        // ColliderForFirstAbility.radius = 521.5f;






        Nil_FOVdetection.immobilosingRipple = false;














        yield return new WaitForSeconds(5.5f);









        Drone_Second_ability_Liban RTY = GameObject.Find("Activate Drone second ability").GetComponent<Drone_Second_ability_Liban>();


        RTY.enabled = true;















        Drone_First_Ability_Liban PDFG = GameObject.Find("Activate Drone first ability").GetComponent<Drone_First_Ability_Liban>();

        PDFG.enabled = true;












        Light_Hold_Blue QAS = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();


        QAS.enabled = true;


















    }







}
