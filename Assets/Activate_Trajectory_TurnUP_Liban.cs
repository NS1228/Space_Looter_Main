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


    public Transform OGPlayer;




    public Vector3 backtorot;


    public Transform Torch;


    public Vector3 Torchbacktorot;






 


    // Update is called once per frame
    void Update()
    {







        if (Input.GetKeyDown(KeyCode.L))


        {



            StartCoroutine(TURNIT());



        }

    }




    IEnumerator TURNIT()




    {




        TrajectoryCAM.transform.parent = null;



        TrajectoryCAM.gameObject.SetActive(true);



        ThirdCam.gameObject.SetActive(false);



        CursorScript.gameObject.SetActive(true);





        RBFPS.gameObject.SetActive(false);





        Projectile_Donut GalacticDonut = GameObject.Find("Character").GetComponent<Projectile_Donut>();



        GalacticDonut.enabled = true;







        print("LOOOOOL yoyoyoyoo OH MYYYY");
















        yield return new WaitForSeconds(6.0f);






        REturnRotation();





        TrajectoryCAM.gameObject.SetActive(false);



        TrajectoryCAM.transform.position = WhereTheCamWillSpawn.position;




        ThirdCam.gameObject.SetActive(true);




        RBFPS.gameObject.SetActive(true);






        Projectile_Donut GalacticDonut22 = GameObject.Find("Character").GetComponent<Projectile_Donut>();


        GalacticDonut22.enabled = false;







        LineRenderer LR = GameObject.Find("Character").GetComponent<LineRenderer>();


        LR.enabled = false;








    }






    void REturnRotation()

    {

        if (OGPlayer.transform.eulerAngles != backtorot)



        {

            OGPlayer.transform.rotation = Quaternion.Euler(backtorot.y, backtorot.y, backtorot.z);



            Torch.transform.rotation = Quaternion.Euler(Torchbacktorot.x, Torchbacktorot.y, Torchbacktorot.z);




        }



    }

}
        





    








       












      

















    