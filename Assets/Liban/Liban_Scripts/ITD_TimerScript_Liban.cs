using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ITD_TimerScript_Liban : MonoBehaviour
{



    private float EDTimerr;

    public Text EDtexttt;

    public GameObject ITD_Device;



    // Start is called before the first frame update
    void Start()
    {



        EDTimerr = 4.5f;

        
    }

    // Update is called once per frame
    void Update()
    {


        TimeUP();




        EDTimerr -= Time.deltaTime;




        int seconds = (int)(EDTimerr % 60);



        string EDtext = string.Format("{0:0}", seconds);



        EDtexttt.text = EDtext;


        
    }







    void TimeUP()



    {


        if(EDTimerr <= 0)


        {



            ITD_Device.GetComponent<SphereCollider>().radius = 10.0f;



            ITD_Device.GetComponent<SphereCollider>().center = new Vector3(0, 0, -3);








        }





    }





}

