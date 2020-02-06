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



    void OnTriggerEnter (Collider other)

    {


        if(other.CompareTag("Player"))

        {

            //activate the camera switch in here yeahyeah



            CameraSwitch SwitchSwitch = GameObject.Find("camera switch script empty object new").GetComponent<CameraSwitch>();

            SwitchSwitch.enabled = true;



            print("yo hi");


            StartCoroutine(ActivateTEXTS(other));


        }
        
    }



    IEnumerator ActivateTEXTS (Collider player)


    {



        PressJToSwitch.gameObject.SetActive(true);

        PressOForNV.gameObject.SetActive(true);

        PressYforZoom.gameObject.SetActive(true);



        yield return new WaitForSeconds(4.5f);


        PressJToSwitch.gameObject.SetActive(false);

        PressOForNV.gameObject.SetActive(false);

        PressYforZoom.gameObject.SetActive(false);

        AllYEAH.SetActive(false);









    }



}
