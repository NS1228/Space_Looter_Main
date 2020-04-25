using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Final_ExposeEnemies_ITD_Liban : MonoBehaviour
{



    public float FinalTimer;

    public AudioSource WaveeeSound;




    // Start is called before the first frame update
    void Start()
    {


        FinalTimer = 8.0f;
        
    }

    // Update is called once per frame
    void Update()
    {




        //The Timer

        FinalTimer -= Time.deltaTime;



        int secondss = (int)(FinalTimer % 60);











        //Input


        if(Input.GetMouseButton(1))

        {




            GameObject[] enemies = GameObject.FindGameObjectsWithTag("AI");



            foreach (GameObject go in enemies)


            {
                go.GetComponent<Outline>().enabled = true;
            }




            ITD_StunLight_Liban YHYHITD2 = GameObject.FindWithTag("Light").GetComponent<ITD_StunLight_Liban>();

            YHYHITD2.enabled = false;


            FinalTimer = 8.0f;

        }








        //if timer is below 0 then...





        if(FinalTimer <= 0)

        {


            GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("AI");



            foreach (GameObject goes in enemies2)


            {
                goes.GetComponent<Outline>().enabled = false;
            }




            GameObject[] enemies3 = GameObject.FindGameObjectsWithTag("Final");



            foreach (GameObject goeees in enemies3)


            {
                goeees.GetComponent<Final_ExposeEnemies_ITD_Liban>().enabled = false;
            }





            FinalTimer = 8.0f;


            WaveeeSound.Stop();







            GameObject[] enemies6 = GameObject.FindGameObjectsWithTag("FlashLight");



            foreach (GameObject goeeees in enemies6)


            {
                goeeees.GetComponent<Stun_Light_Liban>().enabled = true;
            }



        }








    }
}
