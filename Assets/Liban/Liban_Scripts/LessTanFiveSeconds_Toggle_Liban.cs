using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LessTanFiveSeconds_Toggle_Liban : MonoBehaviour
{


    public Text TheTimerTExt;



    // Start is called before the first frame update
    void Start()
    {


        StartCoroutine(ToggleONOFFyh());

    }

    // Update is called once per frame
    void Update()
    {

        
    }







    IEnumerator ToggleONOFFyh()


    {


        while (true)


        {


            yield return new WaitForSeconds(0.3f);
           


            TheTimerTExt.enabled = !TheTimerTExt.enabled;



        }



    }




}
