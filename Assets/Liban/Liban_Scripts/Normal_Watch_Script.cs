using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_Watch_Script : MonoBehaviour
{


   // public GameObject FakePlayer;

   // public Transform ThePlayer;

   // public Transform Face;

   // public Transform CloningPoint1;

   // public Transform CloningPoint2;

   // public Transform CloningPoint3;

   // public GameObject Watchyeah;

   // public ParticleSystem Smoke;

   // public Material Ghost;

   // public Material Normal;




    void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))




        {

            ActivateWatchAbility AAW = GameObject.Find("Activate the watch ability").GetComponent<ActivateWatchAbility>();

            AAW.enabled = true;


            print("calmmmm");



            Light_Hold_Blue LHBY = GameObject.FindWithTag("FlashLight").GetComponent<Light_Hold_Blue>();

            LHBY.enabled = false;



            ActivateWatchAbilityTwo_Liban LYPTO = GameObject.Find("Activate second watch ability").GetComponent<ActivateWatchAbilityTwo_Liban>();


            LYPTO.enabled = true;



            Stun_Light_Liban STGH = GameObject.FindWithTag("FlashLight").GetComponent<Stun_Light_Liban>();

            STGH.enabled = false;


        }

    }
}






   // IEnumerator GhostActivation(Collider player)


   // {

      //  Watchyeah.GetComponent<MeshRenderer>().enabled = false;

       // Watchyeah.GetComponent<BoxCollider>().enabled = false;



      //  GameObject Clo = Instantiate(FakePlayer, CloningPoint1.position, CloningPoint1.rotation);

     //   GameObject Clo2 = Instantiate(FakePlayer, CloningPoint2.position, CloningPoint2.rotation);

      //  GameObject Clo3 = Instantiate(FakePlayer, CloningPoint3.position, CloningPoint3.rotation);


      //  Smoke.gameObject.SetActive(true);


      //  ThePlayer.GetComponent<MeshRenderer>().material = Ghost;


      //  Face.GetComponent<MeshRenderer>().material = Ghost;






      //  yield return new WaitForSeconds(5.0f);





      //  ThePlayer.GetComponent<MeshRenderer>().material = Normal;


      //  Face.GetComponent<MeshRenderer>().material = Normal;

        



      //  Destroy(Clo);

      //  Destroy(Clo2);

      //  Destroy(Clo3);




      //  yield return new WaitForSeconds(8.0f);





     //   Watchyeah.GetComponent<MeshRenderer>().enabled = true;

      //  Watchyeah.GetComponent<BoxCollider>().enabled = true;




   // }


//}


