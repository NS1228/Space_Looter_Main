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



            INstant_Liban IL = GameObject.FindWithTag("Gunk Loc").GetComponent<INstant_Liban>();

            IL.enabled = true;





            Cheese_ShrinkingPOWERUP ASDQW = GameObject.FindWithTag("CheesePowerUp").GetComponent<Cheese_ShrinkingPOWERUP>();

            ASDQW.enabled = false;



            GetComponent<Activate_CheeseAbilities_Liban>().enabled = false;




        }











   





    }


}


