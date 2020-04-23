using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class FlashingDanger : MonoBehaviour
{


    public Text Danger;



    // Start is called before the first frame update
    void Start()
    {


        Danger = GetComponent<Text>();



        StartCoroutine(FlashingFlashing());

        
    }



    IEnumerator FlashingFlashing()


    {


        while (true)


        {

            yield return new WaitForSeconds(0.3f);


            Danger.enabled = !Danger.enabled;

            


        }

        
    }
}
