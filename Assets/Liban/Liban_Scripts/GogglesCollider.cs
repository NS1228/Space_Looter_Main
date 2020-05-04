using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GogglesCollider : MonoBehaviour
{



    public GameObject AllYEAH;

    public Text PressJToSwitch;

    public Text PressOForNV;

    public Text PressYforZoom;



    void Start()

    {


        

        

            //activate the camera switch in here yeahyeah



             




            print("yo hi hi hi");


            StartCoroutine(ActivateTEXTS());


           


        
        
    }



    IEnumerator ActivateTEXTS ()


    {



        PressJToSwitch.gameObject.SetActive(true);

        PressOForNV.gameObject.SetActive(true);

        PressYforZoom.gameObject.SetActive(true);







        yield return new WaitForSeconds(3.5f);
           






        PressJToSwitch.gameObject.SetActive(false);

        PressOForNV.gameObject.SetActive(false);

        PressYforZoom.gameObject.SetActive(false);

        AllYEAH.SetActive(false);









    }



}
