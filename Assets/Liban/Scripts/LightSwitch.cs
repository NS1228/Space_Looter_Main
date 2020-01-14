using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{


    public Light TorchLight;

    public Light GlassLight;

    private bool isOn; 



    // Start is called before the first frame update
    void Start()
    {


        GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {



        if(Input.GetKeyDown(KeyCode.G))

        {


            isOn = !isOn;





            if (isOn)


            {


                LightON();


            }


            else

            {


                LightOff();

            }


        }




        void LightON()

        {

            TorchLight.gameObject.SetActive(true);

            GlassLight.gameObject.SetActive(true);




        }




        void LightOff()

        {

            TorchLight.gameObject.SetActive(false);

            GlassLight.gameObject.SetActive(false);


        }


    }
}
