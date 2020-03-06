using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DroneHealth_Script : MonoBehaviour
{


    public float DroneHealth = 9000.0f;

    public float CurrentDroneHealth;

    public Slider DroneHealthBar;

    public float DroneBatteryDraineryh = 0.000000002f;

    private float DroneBatteryTimer;


    // Start is called before the first frame update
    void Start()
    {




        //  CurrentDroneHealth = DroneHealth;


        DroneHealth = CurrentDroneHealth;


    }

    // Update is called once per frame

    void Update()
    {


        DrainDroneBattery();


        //   DieDie();






    }





    void DieDie()


    {



        if (DroneHealth <= 0)

        {




            Destroy(gameObject);


        }

    }




    void DrainDroneBattery()



    {



        DroneBatteryDraineryh = Time.timeSinceLevelLoad + 1.0f;






        if (Time.deltaTime >= DroneBatteryTimer)

        {


            CurrentDroneHealth -= DroneBatteryDraineryh;


            DroneHealthBar.value = CurrentDroneHealth;


        }



        if (CurrentDroneHealth <= 0)


        {


            DieDie();

        }




    }


}

      
