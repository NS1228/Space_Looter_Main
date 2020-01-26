using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Light_Hold : MonoBehaviour
{


    public Light TorchLight;

    public Light GlassLight;

    public AudioSource LightSwitchSound;



    // Start is called before the first frame update
    void Start()
    {


        GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {




        if(Input.GetKeyDown(KeyCode.N))

        {



            TorchLight.gameObject.SetActive(true);


            GlassLight.gameObject.SetActive(true);

          
            LightSwitchSound.Play();

        }

        else

        {


            if(Input.GetKeyUp(KeyCode.N))


            {

                TorchLight.gameObject.SetActive(false);


                GlassLight.gameObject.SetActive(false);

                LightSwitchSound.Play();


            }
        }


        
        
        
        


    }
}
