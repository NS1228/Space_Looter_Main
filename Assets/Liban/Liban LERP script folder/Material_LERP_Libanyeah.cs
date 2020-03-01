using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_LERP_Libanyeah : MonoBehaviour
{


    private Color newcolour;



    public float lerptime = 3.0f;









    void Update()

    {



        thecolourchanging();

    }




    void thecolourchanging()

    {




        Color redcolour = Color.red;


        Color blackcolour = Color.black;


        if (Input.GetKeyDown(KeyCode.T))

        {

            newcolour = redcolour;


        }



        newcolour =  Color.Lerp(redcolour, blackcolour, Time.deltaTime * lerptime);





    }




}
