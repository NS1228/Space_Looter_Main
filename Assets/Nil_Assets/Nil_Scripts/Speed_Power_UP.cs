using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Power_UP : MonoBehaviour
{


  //  public float Powerupspeed = 2.5f;

    public Light ShoeLight;

    public Transform ThePlayer;

    public GameObject GLightBlue;

    public GameObject GLightGreen;

    public GameObject TLightBlue;

    public GameObject TLightGreen;

    public GameObject TheShoe;

    public bool CoolDownSpeed;


    private float SpeedBoost = 1.1f;





     void Start()
    {


       


    }




    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))


        {


            StartCoroutine(PowerUPNOW(other));


        }

    }


    IEnumerator PowerUPNOW(Collider player)



    {



        GLightBlue.SetActive(false);

        GLightGreen.SetActive(false);

        TLightBlue.SetActive(false);

        TLightGreen.SetActive(false);



        // NewMovementScript moving = player.GetComponent<NewMovementScript>();

        //  moving.MovementSpeed *= Powerupspeed;


        TheShoe.GetComponent<MeshRenderer>().enabled = false;


        ShoeLight.gameObject.SetActive(false);


        //  ThePlayer.GetComponent<AudioSource>().maxDistance = 7.0f;


        Turn_Off_TorchScript TurnOff = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

        TurnOff.enabled = true;


        Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

        B_Light.enabled = false;


        Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

        G_Light.enabled = false;





        yield return new WaitForSeconds(3.7f);



        TheShoe.GetComponent<MeshRenderer>().enabled = true;


        ShoeLight.gameObject.SetActive(true);



        //  moving.MovementSpeed /= Powerupspeed;


        //  ThePlayer.GetComponent<AudioSource>().maxDistance = 1.05f;



          Turn_Off_TorchScript TurnOff2 = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

           TurnOff2.enabled = false;



        Light_Hold_Blue B_Light2 = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

        B_Light2.enabled = true;


        Light_Hold_Green G_Light2 = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

        G_Light2.enabled = true;


        Battery_Level Batteryyeah2 = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

        Batteryyeah2.enabled = true;



        //  LemarMovment LCool = GameObject.Find("Playerlemar").GetComponent<LemarMovment>();

        //  LCool.Speed /= SpeedBoost;





       





    }
}
