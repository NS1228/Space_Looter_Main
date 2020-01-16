using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Power_UP : MonoBehaviour
{


    public float Powerupspeed = 2.5f;
    
    public Light ShoeLight;



    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))


        {


            StartCoroutine(PowerUPNOW(other));


        }

    }


    IEnumerator PowerUPNOW(Collider player)



    {


        NewMovementScript moving = player.GetComponent<NewMovementScript>();

        moving.MovementSpeed *= Powerupspeed;

        GetComponent<MeshRenderer>().enabled = false;

        ShoeLight.gameObject.SetActive(false);


        yield return new WaitForSeconds(6.0f);


        moving.MovementSpeed /= Powerupspeed;







    }
}
