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


    public GameObject TrajectCursor;


    public GameObject GRText;


    public GameObject Torchyh;

    public Vector3 backtorot;


    public Transform Torch;


    public Vector3 Torchbacktorot;


    public AudioSource CountdownSoundEffect;








    void Update()
    {




        if (Input.GetKeyDown(KeyCode.L))


        {



            StartCoroutine(TURNIT());

            Torchyh.SetActive(false);
        }



    }



    IEnumerator TURNIT()

    {



        TrajectoryCAM.transform.parent = null;



        TrajectoryCAM.gameObject.SetActive(true);



        ThirdCam.gameObject.SetActive(false);



        CursorScript.gameObject.SetActive(true);





        RBFPS.gameObject.SetActive(false);





        TrajectCursor.gameObject.SetActive(true);



        CountdownSoundEffect.Play();


        GRText.gameObject.SetActive(true);






        Projectile_Donut GalacticDonut = GameObject.Find("Character").GetComponent<Projectile_Donut>();



        GalacticDonut.enabled = true;





        print("LOOOOOL yoyoyoyoo OH MYYYY");






        LineRenderer LR4 = GameObject.Find("Character").GetComponent<LineRenderer>();


        LR4.enabled = true;





        Activate_Trajectory_TurnUP_Liban HKJLG = GameObject.FindWithTag("ACTGRE").GetComponent<Activate_Trajectory_TurnUP_Liban>();

        HKJLG.enabled = false;





        Grenade_Timer_Text_Liban GT_Timer = GameObject.Find("Grenade Timer Text").GetComponent<Grenade_Timer_Text_Liban>();



        GT_Timer.enabled = true;
















        yield return new WaitForSeconds(10.1f);











        Projectile_Donut GalacticDonut22 = GameObject.Find("Character").GetComponent<Projectile_Donut>();


        GalacticDonut22.enabled = false;




        Torchyh.SetActive(true);


        // Grenade_Timer_Text_Liban GT_Timer3 = GameObject.Find("Grenade Timer Text").GetComponent<Grenade_Timer_Text_Liban>();


        // GT_Timer3.GrenadeTimerTimer = 10.0f;





        CountdownSoundEffect.Stop();





        TrajectCursor.gameObject.SetActive(false);




        TrajectoryCAM.gameObject.SetActive(false);



        TrajectoryCAM.transform.position = WhereTheCamWillSpawn.position;




        ThirdCam.gameObject.SetActive(true);




        RBFPS.gameObject.SetActive(true);


        GRText.gameObject.SetActive(false);






      //  Light_Hold_Blue GF = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();


      //  GF.TorchLightBlue.gameObject.SetActive(true);







        LineRenderer LR = GameObject.Find("Character").GetComponent<LineRenderer>();


        LR.enabled = false;





       








        yield return new WaitForSeconds(6.0f);






        TrajectoryCAM.transform.SetParent(OGPlayer);


        TrajectoryCAM.transform.position = WhereTheCamWillSpawn.transform.position;



        TrajectoryCAM.transform.rotation = WhereTheCamWillSpawn.transform.rotation;







        Activate_Trajectory_TurnUP_Liban ATURHN3 = GameObject.FindWithTag("ACTGRE").GetComponent<Activate_Trajectory_TurnUP_Liban>();


        ATURHN3.enabled = true;






    }





}



































   

   

    


        





    








       












      

















    