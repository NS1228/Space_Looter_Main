using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_SpeedBoost_Script_Liban : MonoBehaviour
{

    public float PowerUpTimer = 16;


    public Transform ThePlayerYHYHYH;


    public GameObject TheShoeCMON;





    // Start is called before the first frame update
    void Start()
    {







    }

    // Update is called once per frame
    void Update()

    {


      



        PowerUpTimer -= Time.deltaTime;


        int secs = (int)(PowerUpTimer % 60);












        if(PowerUpTimer <= 16)

        {




            print("Boot Power Up Active!");



        }







        if (PowerUpTimer <= 10 && GameObject.Find("newPlayer").GetComponent<LemarMovment>().Speed > 15 || GameObject.Find("newPlayer").GetComponent<LemarMovment>().Speed < 15)


        {



            LemarMovment spspsp = GameObject.Find("newPlayer").GetComponent<LemarMovment>();

            spspsp.Walk = 15;




            GetComponent<Turn_Off_TorchScript>().enabled = false;



          //  GetComponent<New_SlowDownScriptBoot_Liban>().enabled = false;


          //  GetComponent<New_SpeedBoost_Script_Liban>().enabled = false;


            GetComponent<Activate_NewPowerUP_Script_Liban>().enabled = false;



        }







        if (PowerUpTimer <= 1)


        {



            GetComponent<New_SpeedBoost_Script_Liban>().enabled = false;



            GetComponent<Activate_NewPowerUP_Script_Liban>().enabled = false;





        }













        if (PowerUpTimer <= 1)

        {



           




            PowerUpTimer = 16;




            print("back up and running yay");





            this.gameObject.GetComponent<MeshCollider>().enabled = true;




            


           



            


        }




    }





}


    


    




    