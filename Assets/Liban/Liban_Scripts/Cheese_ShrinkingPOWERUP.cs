using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_ShrinkingPOWERUP : MonoBehaviour
{

    public Transform ThePlayer;

    public float Shrink = 1.3f;

    public float BackToNormal = 1.3f;

    public Transform TorchForPlayer;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()


    {


        if(Input.GetMouseButtonDown(1))

        {


            StartCoroutine(Shrinkingyeahyeah());



        }


    }



    IEnumerator Shrinkingyeahyeah()


    {


        ThePlayer.transform.localScale /= Shrink;

        TorchForPlayer.transform.localScale /= Shrink;



        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;



        yield return new WaitForSeconds(6.4f);


       

        ThePlayer.transform.localScale *= BackToNormal;

        TorchForPlayer.transform.localScale *= BackToNormal;

        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;







        yield return new WaitForSeconds(3.0f);


        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;

        print("nice");


    }




}
