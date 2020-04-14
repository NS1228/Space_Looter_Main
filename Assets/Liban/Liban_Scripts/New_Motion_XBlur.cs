using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class New_Motion_XBlur : MonoBehaviour
{


    public Transform ThePlayer;

    public PostProcessingProfile Disorientate;





    void Update()

    {




        float movingnowX = Input.GetAxis("Horizontal");

        float movingnowZ = Input.GetAxis("Vertical");


        // !this.GetComponent<PostProcessingBehaviour>().profile == Disorientate


        if (movingnowX != 0 || movingnowZ != 0)


        {

            PostProcessingBehaviour PPyeahyeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPyeahyeah.enabled = true;


            print("changed yeah yeah");


        }



        else

        {


            PostProcessingBehaviour PPyeahyeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPyeahyeah.enabled = false;


        }








        if(!this.GetComponent<PostProcessingBehaviour>().profile == Disorientate)


        {




            PostProcessingBehaviour PPyeahyeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPyeahyeah.enabled = false;


            print("changed yeah yeah 32");





        }



        



    }
}



