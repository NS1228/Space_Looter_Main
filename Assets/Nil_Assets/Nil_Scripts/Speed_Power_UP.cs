using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Power_UP : MonoBehaviour
{


    //  public float Powerupspeed = 2.5f;

    public Light ShoeLight;

    public Transform ThePlayer;

    public GameObject TheShoe;

    public bool CoolDownSpeed;









    void Start()
    {






    }




    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))


        {


          //  StartCoroutine(PowerUPNOW(other));

        }

    }


    IEnumerator PowerUPNOW(Collider player)



    {





        TheShoe.GetComponent<MeshRenderer>().enabled = false;


        ShoeLight.gameObject.SetActive(false);





        Turn_Off_TorchScript TurnOff = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

        TurnOff.enabled = true;


        Light_Hold_Blue B_Light = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

        B_Light.enabled = false;


        Stun_Light_Liban G_Light = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

        G_Light.enabled = false;












        yield return new WaitForSeconds(5.9f);








       // print("yhyhyhyh");








        Turn_Off_TorchScript TurnOff2 = GameObject.Find("Boot Skin").GetComponent<Turn_Off_TorchScript>();

        TurnOff2.enabled = false;





        Light_Hold_Blue B_Light2 = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

        B_Light2.enabled = true;





        Stun_Light_Liban G_Light2 = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

        G_Light2.enabled = true;





        Battery_Level Batteryyeah2 = GameObject.FindWithTag("FlashLight").GetComponent<Battery_Level>();

        Batteryyeah2.enabled = true;
















        








      


            yield return new WaitForSeconds(1.0f);




                TheShoe.GetComponent<MeshRenderer>().enabled = true;


                ShoeLight.gameObject.SetActive(true);


            }





        }
    
