using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_ShrinkingPOWERUP : MonoBehaviour
{

    public Transform ThePlayer;

    public int Shrink = 3;

    public int BackToNormal = 3;

    public Transform TorchForPlayer;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)


    {


        if(other.CompareTag("Player"))

        {


            StartCoroutine(Shrinkingyeahyeah(other));



        }


    }



    IEnumerator Shrinkingyeahyeah(Collider player)


    {


        ThePlayer.transform.localScale /= Shrink;

        TorchForPlayer.transform.localScale /= Shrink;



       // TorchForPlayer.SetActive(false);



        yield return new WaitForSeconds(2.4f);


       // TorchForPlayer.SetActive(true);

        ThePlayer.transform.localScale *= BackToNormal;

        TorchForPlayer.transform.localScale *= BackToNormal;




    }




}
