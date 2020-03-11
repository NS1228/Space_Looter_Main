using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inst_liban : MonoBehaviour
{
    private float timetimer = 3f;


    public Transform spawnloc;


    public GameObject cubeeee;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        INST();



    }



    void INST()

    {




        if (Input.GetMouseButton(1))



        {




            timetimer -= Time.deltaTime;


            if (timetimer <= 0)



            {



                Instantiate(cubeeee, spawnloc.position, Quaternion.identity);



                timetimer = 3f;


            }








        }










    }
}
