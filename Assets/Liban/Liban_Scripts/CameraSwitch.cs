using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{


    public Camera FirstPersonCamera;

    public Camera OriginalCamera;

    private bool SwitchYeah;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.J))

        {



            SwitchYeah = !SwitchYeah;



        }



        if(SwitchYeah)


        {

            FirstPersonCamera.gameObject.SetActive(true);

            OriginalCamera.gameObject.SetActive(false);

        }

        else

        {


            OriginalCamera.gameObject.SetActive(true);

            FirstPersonCamera.gameObject.SetActive(false);

        }

        
    }
}
