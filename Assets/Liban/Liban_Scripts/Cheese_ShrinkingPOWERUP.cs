using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_ShrinkingPOWERUP : MonoBehaviour
{

    public Transform ThePlayer;

    public float Shrink = 1.3f;

    public float BackToNormal = 1.3f;

    public GameObject TheTorchl;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()


    {
        //change to if icon is selected

        if(Input.GetMouseButtonDown(1))

        {


            StartCoroutine(Shrinkingyeahyeah());

            TheTorchl.SetActive(false);

        }


    }



    IEnumerator Shrinkingyeahyeah()


    {


        ThePlayer.transform.localScale /= Shrink;

        



        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;

        GetComponent<Cheese_Gunk_Liban>().enabled = false;



        yield return new WaitForSeconds(5.4f);


       

        ThePlayer.transform.localScale *= BackToNormal;

        

        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;



        TheTorchl.SetActive(true);





        yield return new WaitForSeconds(3.0f);


        

        print("get back there");


    }




}
