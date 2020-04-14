using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_CheckIf_ZoomedIn_Liban : MonoBehaviour
{

    public Camera DAFPS;



    // Start is called before the first frame update
    void Start()
    {


        GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {



        float movingnowX2 = Input.GetAxis("Horizontal");

        float movingnowZ2 = Input.GetAxis("Vertical");






        if (DAFPS.fieldOfView == 22f && movingnowX2 != 0 || movingnowZ2 != 0)



        {


            print("ha");




            GameObject[] yuoiu = GameObject.FindGameObjectsWithTag("Player");


                foreach (GameObject yaattaaa in yuoiu)

            {


                yaattaaa.GetComponent<New_Motion_XBlur>().enabled = true;
            }




        }



    }
}
