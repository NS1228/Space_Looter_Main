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







    // Update is called once per frame
    void Update()
    {



        if(Input.GetKeyDown(KeyCode.V))


        {


            StartCoroutine(TrajectoryActivation());

            print("LOL");


        }

        
    }







    IEnumerator TrajectoryActivation()



    {



        Rigidbody LMLM = GameObject.Find("newPlayer").GetComponent<Rigidbody>();



        LMLM.isKinematic = true;









        yield return new WaitForSeconds(4.0f);










        Rigidbody LMLM2 = GameObject.Find("newPlayer").GetComponent<Rigidbody>();


        LMLM2.isKinematic = true;











    }






}
