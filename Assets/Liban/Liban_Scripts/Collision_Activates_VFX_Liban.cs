using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Collision_Activates_VFX_Liban : MonoBehaviour
{


    public GameObject SmokeySmokey;


    public GameObject ExplosionExplosion;


    public GameObject TheeeeGrenadeyh;


    public AudioSource Explosionbrrr;







  





    // Start is called before the first frame update
    void Start()
    {


        



    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "Ground")


        {









            StartCoroutine(Boom());



            print("yeahyeah");



          


            //  TheeeeGrenadeyh.GetComponent<SphereCollider>().radius = 5.7f;





            Explosionbrrr.Play();


          



           





            






        }




 }






    IEnumerator Boom()



    {




         SmokeySmokey.gameObject.SetActive(true);



         ExplosionExplosion.gameObject.SetActive(true);







         





        yield return new WaitForSeconds(1.8f);









        this.gameObject.SetActive(false);











    }



}


 