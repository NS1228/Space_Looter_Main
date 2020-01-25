using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GogglesCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {


        if(other.CompareTag("Player"))

        {

            //activate the camera switch in here yeahyeah



            CameraSwitch SwitchSwitch = GameObject.Find("Original Camera").GetComponent<CameraSwitch>();

            SwitchSwitch.enabled = true;


            print("yo hi");

        }
        
    }
}
