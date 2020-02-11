using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drone_Script : MonoBehaviour
{


    public Transform Enemyyeah;

    public Text EnemiesDetected;

    public Light DroneLight;

    public Slider DroneHealthSlider;



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


        DroneHealthSlider.gameObject.SetActive(true);


        DroneHealth_Script DHealth = GameObject.Find("Drone Skin").GetComponent<DroneHealth_Script>();

        DHealth.enabled = true;



        yield return new WaitForSeconds(4.0f);    //kinda shows that spacing is important when it comes to this function




        Enemyyeah.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;


        Outline EnemyOutline2n = GameObject.Find("enemy sphere 2").GetComponent<Outline>();

        EnemyOutline2n.enabled = false;


        Outline EnemyOultine3n = GameObject.Find("enemy sphere 3").GetComponent<Outline>();

        EnemyOultine3n.enabled = false;


        Outline EnemyOutline4n = GameObject.Find("enemy sphere 4").GetComponent<Outline>();

        EnemyOutline4n.enabled = false;


        EnemiesDetected.gameObject.SetActive(false);


       // GetComponent<MeshRenderer>().enabled = true;

     //  DroneLight.gameObject.SetActive(true);



        DroneHealthSlider.gameObject.SetActive(false);


        DroneHealth_Script DHealth2 = GameObject.Find("Drone Skin").GetComponent<DroneHealth_Script>();

        DHealth2.enabled = false;




        yield return new WaitForSeconds(4.0f);



        GetComponent<MeshRenderer>().enabled = true;

        DroneLight.gameObject.SetActive(true);



    }
}

