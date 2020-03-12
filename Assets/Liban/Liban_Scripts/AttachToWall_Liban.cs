using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToWall_Liban : MonoBehaviour
{


    public GameObject ElecDevice;

    





    void OnTriggerEnter(Collider other)
    {






        if (other.CompareTag("Wall"))


        {




            ElecDevice.transform.SetParent(null);





            ITD_TimerScript_Liban ITDITD = GameObject.FindWithTag("PickUpObject").GetComponent<ITD_TimerScript_Liban>();

            ITDITD.enabled = true;




            ElecDevice.GetComponent<SphereCollider>().enabled = false;



            


        }




        }




    }




    



 