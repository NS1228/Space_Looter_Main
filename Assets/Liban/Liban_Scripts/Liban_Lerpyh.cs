using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liban_Lerpyh : MonoBehaviour
{


    public Material ThisObjectMaterialyh;

    private float LerpSpeed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.C))



        {



            ThisObjectMaterialyh.color = Color.Lerp(ThisObjectMaterialyh.color, Color.yellow, Time.deltaTime * LerpSpeed);



        }


        
    }
}
