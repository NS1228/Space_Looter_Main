using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITD_StunLight_Liban : MonoBehaviour
{

    public GameObject ITDStunLight;


    public float StunLightTimer;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        ITDTimer_();



        if(Input.GetMouseButtonDown(0))


        {


            ITDStunLight.gameObject.SetActive(true);



            StunLightTimer = Time.timeSinceLevelLoad + 0.1f;






        }




        
    }







    void ITDTimer_ ()


    {



        if(Time.timeSinceLevelLoad >= StunLightTimer)


        {


            ITDStunLight.gameObject.SetActive(false);


        }





    }

}
