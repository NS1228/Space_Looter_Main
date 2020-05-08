using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese_ShrinkingPOWERUP : MonoBehaviour
{

    public Transform ThePlayer;

    public float Shrink = 1.3f;

    public float BackToNormal = 1.3f;

    public GameObject TheTorchl;

    public GameObject CTrigger;
    public GameObject CVisual;
    public GameObject RTrigger;
    public GameObject RVisual;
    public GameObject WTrigger;
    public GameObject WVisual;




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
        CTrigger.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        CVisual.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        RTrigger.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        RVisual.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        WTrigger.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
        WVisual.gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);




        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;

        GetComponent<Cheese_Gunk_Liban>().enabled = false;



        yield return new WaitForSeconds(5.4f);


       

        ThePlayer.transform.localScale *= BackToNormal;


        CTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        CVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        RTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        RVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        WTrigger.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        WVisual.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);



        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = false;



        TheTorchl.SetActive(true);







        yield return new WaitForSeconds(7.0f);


        GetComponent<Cheese_Gunk_Liban>().enabled = true;


        GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;


        

        print("shrinking power back on");


    }




}
