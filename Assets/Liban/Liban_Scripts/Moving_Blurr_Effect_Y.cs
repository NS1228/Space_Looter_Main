using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Moving_Blurr_Effect_Y : MonoBehaviour
{


    public Transform ThePlayer;



    // Start is called before the first frame update
    void Start()
    {


        GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {




        float movingnowY = Input.GetAxis("Vertical");



        if(movingnowY != 0)


        {


            PostProcessingBehaviour PPY = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPY.enabled = true;



        }

        else


        {



            PostProcessingBehaviour PPY = GameObject.Find("FPSMainCamera").GetComponent<PostProcessingBehaviour>();


            PPY.enabled = false;



        }

        
    }
}
