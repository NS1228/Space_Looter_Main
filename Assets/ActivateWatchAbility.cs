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

    public GameObject TheWatchYeah;

    public ParticleSystem TheSmoke;

    public Material TheGhoast;

    public Material TheNormal;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {




        if (Input.GetMouseButtonDown(0))

        {


            StartCoroutine(ActivateTheGhost());



        }


    }




    IEnumerator ActivateTheGhost()

    {

        TheWatchYeah.GetComponent<MeshRenderer>().enabled = false;

        TheWatchYeah.GetComponent<BoxCollider>().enabled = false;




        GameObject Clone1 = Instantiate(TheFakePlayer, ACloningPoint1.position, ACloningPoint1.rotation);

        GameObject Clone2 = Instantiate(TheFakePlayer, ACloningPoint2.position, ACloningPoint2.rotation);

        GameObject Clone3 = Instantiate(TheFakePlayer, ACloningPoint3.position, ACloningPoint3.rotation);




        TheSmoke.gameObject.SetActive(true);




        TheePlayer.GetComponent<MeshRenderer>().material = TheGhoast;

        TheesFace.GetComponent<MeshRenderer>().material = TheGhoast;





      //  Light_Hold_Blue BBBB = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

      // BBBB.enabled = false;



        ActivateWatchAbility ACVB = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

        ACVB.enabled = false;




        yield return new WaitForSeconds(3.0f);



        Destroy(Clone1);

        Destroy(Clone2);

        Destroy(Clone3);



        TheePlayer.GetComponent<MeshRenderer>().material = TheNormal;

        TheesFace.GetComponent<MeshRenderer>().material = TheNormal;


        Light_Hold_Blue BBBB2 = GameObject.Find("torcia").GetComponent<Light_Hold_Blue>();

        BBBB2.enabled = true;






        yield return new WaitForSeconds(4.0f);



        TheWatchYeah.GetComponent<MeshRenderer>().enabled = true;

        TheWatchYeah.GetComponent<BoxCollider>().enabled = true;


    }


}








        
