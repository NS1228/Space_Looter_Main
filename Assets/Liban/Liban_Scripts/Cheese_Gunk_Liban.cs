﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_Gunk_Liban : MonoBehaviour
{

    public GameObject Gunk;

    public Transform GunkSpot;

    private float InstanitationTimerr = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetMouseButton(1))


        {



            InstanitationTimerr -= Time.deltaTime;




            StartCoroutine(TheCheeseGunk());




            if(InstanitationTimerr <= 0)



            { 



          GameObject Gunkyyy = Instantiate(Gunk, GunkSpot.position, Quaternion.identity);




        }


        
    }




    IEnumerator TheCheeseGunk()



    {





      //  GameObject Gunky = Instantiate(Gunk, GunkSpot.position, GunkSpot.rotation);






       ActivateWatchAbilityTwo_Liban AZX = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

        AZX.enabled = false;







        yield return new WaitForSeconds(4.5f);







        ActivateWatchAbilityTwo_Liban AZX2 = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();

        AZX2.enabled = true;






       // Destroy(Gunky);




    }




}
