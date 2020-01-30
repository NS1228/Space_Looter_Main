using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Moving_Blurr_Effect_X : MonoBehaviour
{

    public Transform ThePlayer;

    // public Camera FPSCAM;




    



     void Start()


    {


        GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {


        float movingnowX = Input.GetAxis("Horizontal");

        float movingnowY = Input.GetAxis("Vertical");

       



        if (movingnowX != 0 || movingnowY != 0)


        {

            PostProcessingBehaviour PPyeahyeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPyeahyeah.enabled = true;


            print("changed");


        }



        else

        {


            PostProcessingBehaviour PPyeahyeah = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPyeahyeah.enabled = false;



        }
    




       
    }
}
