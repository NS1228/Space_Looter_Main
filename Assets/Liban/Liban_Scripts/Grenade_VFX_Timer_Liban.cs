using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade_VFX_Timer_Liban : MonoBehaviour
{


    public float VFX_Timer;

     





    // Start is called before the first frame update
    void Start()
    {


        VFX_Timer = 3.3f;

        
    }

    // Update is called once per frame
    void Update()
    {


        VFX_Timer -= Time.deltaTime;



        int seconds = (int)(VFX_Timer % 60);



        LessThanOnePointFive();

        
    }







    void LessThanOnePointFive()

    {


        if (VFX_Timer <= 1.5f)

        {



           


            print("brrrr");



            VFX_Timer = 3.3f;


        }





    }


}
