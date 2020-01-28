using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Power_UP : MonoBehaviour
{


    public float Powerupspeed = 2.5f;

    public Light ShoeLight;

    public Transform ThePlayer;

    public GameObject GLightBlue;

    public GameObject GLightGreen;

    public GameObject TLightBlue;

    public GameObject TLightGreen;



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


         GetComponent<MeshRenderer>().enabled = false;


         ShoeLight.gameObject.SetActive(false);


         ThePlayer.GetComponent<AudioSource>().maxDistance = 7.0f;


         Turn_Off_TorchScript TurnOff = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

         TurnOff.enabled = true;

        




        yield return new WaitForSeconds(15.0f);





        //perhaps try to turn off the vetro on the flashlight object?



        //  moving.MovementSpeed /= Powerupspeed;


        ThePlayer.GetComponent<AudioSource>().maxDistance = 1.05f;



            Turn_Off_TorchScript TurnOff2 = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

            TurnOff2.enabled = false;


       



    }
    }
