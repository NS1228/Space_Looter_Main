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



        GrenadeTimerTimer = 7.0f;

        
    }

    // Update is called once per frame
    void Update()
    {




      //  LessThanZero();




        GrenadeTimerTimer -= Time.deltaTime;






        int seconds = (int)(GrenadeTimerTimer % 60);



        string GTimerString = string.Format("{0:0}", seconds);



        GrenadeTimerTextyh.text = GTimerString;




        
    }



  //  void LessThanZero()



  //  {


     //   if(GrenadeTimerTimer <= 0)


      //  {

       //     GrenadeTimerTimer = 7.0f;

            


      //  }




  //  }





}
