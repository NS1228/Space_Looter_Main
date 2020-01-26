using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float Speed = 7.8f;

    public float JumpForce = 11.4f;


    // Start is called before the first frame update
    void Start()
    {

       // GetComponent<Rigidbody>();

        Speed = 7.8f;

        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.UpArrow))


        {

            transform.position += Vector3.forward * Speed * Time.deltaTime;


        }


        if (Input.GetKey(KeyCode.DownArrow))


        {

            transform.position += Vector3.back * Speed * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.LeftArrow))


        {

            transform.position += Vector3.left * Speed * Time.deltaTime;


        }


        if (Input.GetKey(KeyCode.RightArrow))


        {

            transform.position += Vector3.right * Speed * Time.deltaTime;


        }



        if(Input.GetKey(KeyCode.Space))


        {

            transform.position += Vector3.up * JumpForce * Time.deltaTime;

        }




    }
}
