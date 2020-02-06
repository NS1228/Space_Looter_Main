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

    public float SpeedCoolDownTimer;




     void Start()
    {


        CoolDownSpeed = false;


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






        yield return new WaitForSeconds(3.7f);



        TheShoe.GetComponent<MeshRenderer>().enabled = true;


        ShoeLight.gameObject.SetActive(true);

        TheShoe.GetComponent<MeshCollider>().enabled = false;



        //  moving.MovementSpeed /= Powerupspeed;


        //  ThePlayer.GetComponent<AudioSource>().maxDistance = 1.05f;



        Turn_Off_TorchScript TurnOff2 = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

            TurnOff2.enabled = false;

           Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

           B_Light.enabled = true;


         Light_Hold_Green G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Green>();

           G_Light.enabled = true;




        //  TheShoe.GetComponent<MeshCollider>().enabled = false;


        yield return new WaitForSeconds(10.0f);


       // TheShoe.GetComponent<MeshCollider>().enabled = true;


        Turn_Off_TorchScript TurnOff3 = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

        TurnOff3.enabled = true;







    }
    }
