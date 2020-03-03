using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Trajectory_TurnUP_Liban : MonoBehaviour
{


    public GameObject RBFPS;


    public Camera ThirdCam;


    public Camera TrajectoryCAM;


    public GameObject CursorScript;


    public Transform WhereTheCamWillSpawn;


    public float TrajectoryTimer;


    public GameObject OGPlayer;







    // Update is called once per frame
    void Update()
    {



        TrajectoryTimeTime();




        if (Input.GetKeyDown(KeyCode.L))


        {




            Rigidbody YOOOOOO = GameObject.Find("newPlayer").GetComponent<Rigidbody>();


            YOOOOOO.constraints = RigidbodyConstraints.FreezeAll;





            TrajectoryTimer = Time.timeSinceLevelLoad + 5.0f;




            print("LOOOOOL OH MYYYY");




        }





        void TrajectoryTimeTime()



        {


            if (Time.timeSinceLevelLoad >= TrajectoryTimer)


            {




                Rigidbody YO434 = GameObject.Find("newPlayer").GetComponent<Rigidbody>();


                YO434.constraints = RigidbodyConstraints.None;




            }





        }
    }
}




    








       












      

















    