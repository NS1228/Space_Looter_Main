using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DroneHealth_Script : MonoBehaviour
{


    public float DroneHealth = 90.0f;

    public float CurrentDroneHealth;

    public Slider DroneHealthBar;


    // Start is called before the first frame update
    void Start()
    {


        CurrentDroneHealth = DroneHealth;

        
    }

    // Update is called once per frame



    public void EnemyTakingDamage(float amount)
    {

        DroneHealthBar.value = CurrentDroneHealth;


        if(DroneHealth <= 0)


        {


            DieDie();


        }
        
    }



    public void DieDie()


    {



        Destroy(gameObject);


    }



}
