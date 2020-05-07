using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Off_TorchScript : MonoBehaviour
{

    public float SpeedBoost = 10.5f;

    public Transform ThePlayer;

    public GameObject CrawlSound;

    public GameObject RunSound;

    public GameObject WalkSound;

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






        // change back to Getmousebutton if doesnt work 

        if (Input.GetMouseButtonDown(0))


        {






            print("faster faster...");





            // Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            //  B_Light.enabled = false;








            LemarMovment LMoving1 = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

            LMoving1.Walk += SpeedBoost;

            CTrigger.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            CVisual.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            RTrigger.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            RVisual.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            WTrigger.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
            WVisual.gameObject.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);





            RunSound.GetComponent<AudioSource>().maxDistance = 8.0f;

            WalkSound.GetComponent<AudioSource>().maxDistance = 8.0f;

            CrawlSound.GetComponent<AudioSource>().maxDistance = 8.0f;




        }





        if (Input.GetMouseButtonUp(0))


        {





            LemarMovment LMoving = GameObject.Find("FinalPlayer").GetComponent<LemarMovment>();

            LMoving.Walk -= SpeedBoost;


            CTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            CVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            RTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            RVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            WTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            WVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);

            RunSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            WalkSound.GetComponent<AudioSource>().maxDistance = 1.05f;

            CrawlSound.GetComponent<AudioSource>().maxDistance = 1.05f;







        }








        }





    }






















    

