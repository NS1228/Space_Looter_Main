using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drone_Script : MonoBehaviour
{


    public Transform Enemyyeah;

    public Text EnemiesDetected;

    public Light DroneLight;



    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))


        {


            StartCoroutine(FreezeEnemy(other));



        }


    }




    IEnumerator FreezeEnemy(Collider player)




    {

        GetComponent<MeshRenderer>().enabled = false;


        Enemyyeah.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;


        Outline EnemyOutline2 = GameObject.Find("enemy sphere 2").GetComponent<Outline>();

        EnemyOutline2.enabled = true;


        Outline EnemyOultine3 = GameObject.Find("enemy sphere 3").GetComponent<Outline>();

        EnemyOultine3.enabled = true;


        Outline EnemyOutline4 = GameObject.Find("enemy sphere 4").GetComponent<Outline>();

        EnemyOutline4.enabled = true;


        EnemiesDetected.gameObject.SetActive(true);

        DroneLight.gameObject.SetActive(false);


        yield return new WaitForSeconds(4.0f);


        Enemyyeah.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;


        Outline EnemyOutline2n = GameObject.Find("enemy sphere 2").GetComponent<Outline>();

        EnemyOutline2n.enabled = false;


        Outline EnemyOultine3n = GameObject.Find("enemy sphere 3").GetComponent<Outline>();

        EnemyOultine3n.enabled = false;


        Outline EnemyOutline4n = GameObject.Find("enemy sphere 4").GetComponent<Outline>();

        EnemyOutline4n.enabled = false;


        EnemiesDetected.gameObject.SetActive(false);


        GetComponent<MeshRenderer>().enabled = true;

        DroneLight.gameObject.SetActive(true);


    }
}

