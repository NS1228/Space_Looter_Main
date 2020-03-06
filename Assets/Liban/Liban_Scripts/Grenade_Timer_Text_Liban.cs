using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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




        LessThanFive();




        GrenadeTimerTimer -= Time.deltaTime;






        int seconds = (int)(GrenadeTimerTimer % 60);



        string GTimerString = string.Format("{0:0}", seconds);



        GrenadeTimerTextyh.text = GTimerString;


        GrenadeTimerTextyh.gameObject.SetActive(true);



        
    }



    void LessThanFive()



    {


        if(GrenadeTimerTimer <= 5)


        {

            



            LessTanFiveSeconds_Toggle_Liban LTFS = GameObject.Find("Grenade Timer Text").GetComponent<LessTanFiveSeconds_Toggle_Liban>();


            LTFS.enabled = true;




      //  }


      //  else



       // {

         //   LessTanFiveSeconds_Toggle_Liban LTFS2 = GameObject.Find("Grenade Timer Text").GetComponent<LessTanFiveSeconds_Toggle_Liban>();


         //   LTFS2.enabled = false;




        }




    }





}
