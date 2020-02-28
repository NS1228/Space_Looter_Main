using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Drone_InFrontOfPlayer_Liban : MonoBehaviour
{



    public Transform DaDrone;

    public Transform WhereTheDroneWillSpawn;

    public Camera DroneCamera;

    public Camera ThePlayersCamera; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //activate the drone movmeent script in here 



        if(Input.GetKeyDown(KeyCode.Q))


        {



            DaDrone.transform.position = WhereTheDroneWillSpawn.transform.position;



            WhereTheDroneWillSpawn.parent = null;



            DroneCamera.gameObject.SetActive(true);



            ThePlayersCamera.gameObject.SetActive(false);





            Drone_Movement_Liban LibanDrone = GameObject.Find("Drone Skin").GetComponent<Drone_Movement_Liban>();


            LibanDrone.enabled = true;




            LemarMovment LMovementyh = GameObject.Find("newPlayer").GetComponent<LemarMovment>();


            LMovementyh.enabled = false; 





        }


        
    }
}
