using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_Gunk_Liban : MonoBehaviour
{

    public GameObject Gunk;

    public Transform GunkSpot;

    public GameObject TheTorch;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))


        {



            StartCoroutine(GunkGunk());






        }



        IEnumerator GunkGunk()

        {

            TheTorch.SetActive(false);


            INstant_Liban IL = GameObject.FindWithTag("Gunk Loc").GetComponent<INstant_Liban>();

            IL.enabled = true;



            GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;



            yield return new WaitForSeconds(4.0f);




            Cheese_Gunk_Liban CG = GameObject.FindWithTag("CheesePowerUp").GetComponent<Cheese_Gunk_Liban>();

            CG.enabled = false;


            INstant_Liban IL6 = GameObject.FindWithTag("Gunk Loc").GetComponent<INstant_Liban>();

            IL6.enabled = false;


            TheTorch.SetActive(true);




            yield return new WaitForSeconds(7.0f);


            GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;


            GetComponent<Cheese_Gunk_Liban>().enabled = true;


            print("cheese gunk back on");

        }









    }


}


