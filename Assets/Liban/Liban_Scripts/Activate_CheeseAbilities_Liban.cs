using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_CheeseAbilities_Liban : MonoBehaviour
{

    public GameObject TorchPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.C))

        {



            GetComponent<Cheese_Gunk_Liban>().enabled = true;





            GetComponent<Cheese_ShrinkingPOWERUP>().enabled = true;




            GetComponent<Final_Cheese_Timer_Liban>().enabled = true;



            TorchPlayer.SetActive(false);





            print("the cheese");




        }


        
    }
}
