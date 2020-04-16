using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Grenade_Timer_Text_Liban : MonoBehaviour
{



    public float GrenadeTimerTimer;

    public Text GrenadeTimerTextyh;

    




    // Start is called before the first frame update
    void Start()
    {



        GrenadeTimerTimer = 10.0f;


    }

    // Update is called once per frame
    void Update()
    {

        LessThanZero();







        GrenadeTimerTimer -= Time.deltaTime;






        int seconds = (int)(GrenadeTimerTimer % 60);



        string GTimerString = string.Format("{0:0}", seconds);



        GrenadeTimerTextyh.text = GTimerString;


        this.gameObject.GetComponent<Text>().enabled = true;



        



    }








    void LessThanZero()


    {




        if(GrenadeTimerTimer <= 0)



        {



            GrenadeTimerTimer = 10.0f;



            GrenadeTimerTextyh.gameObject.SetActive(true);



            

        }




    }





}
