using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ITD_StunLight_Liban : MonoBehaviour
{

    public GameObject ITDStunLight;


    //public float StunLightTimer;

    public Transform BackToNormalPosition;

    public Transform ITDDevice;

    public AudioSource WaveSound;

    public GameObject Torrrchh;

    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {



        // ITDTimer_();



        if (Input.GetMouseButtonDown(0))


        {




            ITDStunLight.gameObject.SetActive(true);



            //  StunLightTimer = Time.timeSinceLevelLoad + 0.2f;



        }



            if (Input.GetMouseButtonUp(0))


            {


                ITDStunLight.gameObject.SetActive(false);




                ITD_StunLight_Liban YHYHITD = GameObject.FindWithTag("Light").GetComponent<ITD_StunLight_Liban>();

                YHYHITD.enabled = false;




            ITDDevice.transform.position = BackToNormalPosition.transform.position;
            ITDDevice.transform.parent = Player.transform;


            WaveSound.Stop();




            Final_ExposeEnemies_ITD_Liban FINALLLL = GameObject.FindWithTag("Final").GetComponent<Final_ExposeEnemies_ITD_Liban>();

            FINALLLL.enabled = false;


            Torrrchh.SetActive(true);

        }



        }


}







  