using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_SlowDownScriptBoot_Liban : MonoBehaviour
{
    public float Slowerrrboost = 5f;

    public Transform ThePlayeeer;

    public GameObject CrawlllSound;

    public GameObject RunnnSound;

    public GameObject WalkkkSound;

    public GameObject CTrigger;
    public GameObject CVisual;
    public GameObject RTrigger;
    public GameObject RVisual;
    public GameObject WTrigger;
    public GameObject WVisual;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetMouseButtonDown(1))


        {



           


             LemarMovment LMoving3 = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

              LMoving3.Walk -= 5;

            CTrigger.gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            CVisual.gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            RTrigger.gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            RVisual.gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            WTrigger.gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            WVisual.gameObject.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);



            print("slower slower...");




        //    RunnnSound.GetComponent<AudioSource>().maxDistance = 0f;

         //   WalkkkSound.GetComponent<AudioSource>().maxDistance = 0f;
         //
          //  CrawlllSound.GetComponent<AudioSource>().maxDistance = 0f;



        }





        if (Input.GetMouseButtonUp(1))



        {

            


            LemarMovment LMoving4 = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

            LMoving4.Walk += 5f;

            CTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            CVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            RTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            RVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            WTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            WVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);


            //  RunnnSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            //  WalkkkSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            //  CrawlllSound.GetComponent<AudioSource>().maxDistance = 1.05f;



        }
    }
}