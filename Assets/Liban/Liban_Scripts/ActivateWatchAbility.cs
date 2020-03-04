using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWatchAbility : MonoBehaviour
{


    public GameObject TheFakePlayer;

    public Transform TheePlayer;

    public Transform TheesFace;

    public Transform ACloningPoint1;

    public Transform ACloningPoint2;

    public Transform ACloningPoint3;

    public Transform ACloningPoint4;

    public GameObject TheWatchYeah;

    public ParticleSystem TheSmoke;

  //  public Material TheGhoast;

  //  public Material TheNormal;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetMouseButtonDown(0))

        {


            StartCoroutine(ActivateTheCLONES());



        }


    }




    IEnumerator ActivateTheCLONES()

    {

        TheWatchYeah.GetComponent<MeshRenderer>().enabled = false;

        TheWatchYeah.GetComponent<BoxCollider>().enabled = false;




        GameObject Clone1 = Instantiate(TheFakePlayer, ACloningPoint1.position, ACloningPoint1.rotation);

        GameObject Clone2 = Instantiate(TheFakePlayer, ACloningPoint2.position, ACloningPoint2.rotation);

        GameObject Clone3 = Instantiate(TheFakePlayer, ACloningPoint3.position, ACloningPoint3.rotation);

        GameObject Clone4 = Instantiate(TheFakePlayer, ACloningPoint4.position, ACloningPoint4.rotation);




        //   TheSmoke.gameObject.SetActive(true);


        ActivateWatchAbility ACVB = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        ACVB.enabled = false;





        Light_Hold_Blue BBBB2 = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

        BBBB2.enabled = false;




        ActivateWatchAbilityTwo_Liban CVBNM = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

        CVBNM.enabled = false;






        yield return new WaitForSeconds(5.0f);



        Destroy(Clone1);

        Destroy(Clone2);

        Destroy(Clone3);

        Destroy(Clone4);




        Light_Hold_Blue BBBB3 = GameObject.Find("torcia").GetComponent<Light_Hold_Blue>();

        BBBB3.enabled = true;






        yield return new WaitForSeconds(6.0f);



        TheWatchYeah.GetComponent<MeshRenderer>().enabled = true;

        TheWatchYeah.GetComponent<BoxCollider>().enabled = true;




        ActivateWatchAbility AVBCN = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        AVBCN.enabled = true;




        ActivateWatchAbilityTwo_Liban ASDF = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();


        ASDF.enabled = true;



    }


}








        
