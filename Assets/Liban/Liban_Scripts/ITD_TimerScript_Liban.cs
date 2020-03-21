using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITD_TimerScript_Liban : MonoBehaviour
{



    private float EDTimerr;

   // public Text EDtexttt;

    public GameObject ITD_Deviceee;



    // Start is called before the first frame update
    void Start()
    {



        EDTimerr = 1.8f;

        
    }

    // Update is called once per frame
    void Update()
    {


        TimeUP();




        EDTimerr -= Time.deltaTime;




        int seconds = (int)(EDTimerr % 60);



      //  string EDtext = string.Format("{0:0}", seconds);



     //   EDtexttt.text = EDtext;


        
    }







    void TimeUP()



    {


        if(EDTimerr <= 0)


        {




            //    ITD_Deviceee.GetComponent<BoxCollider>().size = new Vector3(20, 20, 20);



        //    ITD_Exposee_Enemies_Liban Enemy_EXLIB = GameObject.Find("PickUpObject").GetComponent<ITD_Exposee_Enemies_Liban>();

          //  Enemy_EXLIB.enabled = true;






        }





    }





}

