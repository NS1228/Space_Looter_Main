using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITD_Exposee_Enemies_Liban : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {



<<<<<<< Updated upstream
        if (other.CompareTag("AI"))
=======
        if (other.CompareTag("yo"))
>>>>>>> Stashed changes

        {





            print("hmmmmm");




<<<<<<< Updated upstream
             Outline OT5 = GameObject.FindWithTag("AI").GetComponent<Outline>();
=======
            Outline OT5 = GameObject.FindWithTag("yo").GetComponent<Outline>();
>>>>>>> Stashed changes


            OT5.enabled = true;









        }





    }







}