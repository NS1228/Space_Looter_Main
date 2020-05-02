using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_TurnUp_Grenade_Activation_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if(Input.GetKey(KeyCode.I))



        {


            GetComponent<Activate_Trajectory_TurnUP_Liban>().enabled = true;




            print("hello");

        }
    }
}
