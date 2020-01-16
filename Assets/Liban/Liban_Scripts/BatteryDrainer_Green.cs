

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDrainer_Green : MonoBehaviour
{


    public int TakeAwayBatteryBlue = 1;


    public int DontTakeAwayBattery = 0;
   
        

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))


        {

            GetComponent<Battery_Level>().TakeSomeBatteryBlue(TakeAwayBatteryBlue);


        }

    }

}