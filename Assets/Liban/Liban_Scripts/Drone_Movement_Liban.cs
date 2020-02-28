using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone_Movement_Liban : MonoBehaviour
{



    public int Speed = 3;


    public Transform TheeeDrone;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.LeftArrow))


        {



            transform.position += Vector3.left * Speed * Time.deltaTime;



        }



        if (Input.GetKey(KeyCode.RightArrow))


        {



            transform.position += Vector3.right * Speed * Time.deltaTime;



        }



        if (Input.GetKey(KeyCode.UpArrow))


        {



            transform.position += Vector3.forward * Speed * Time.deltaTime;



        }






        if (Input.GetKey(KeyCode.DownArrow))


        {



            transform.position += Vector3.back * Speed * Time.deltaTime;



        }






    }
}
