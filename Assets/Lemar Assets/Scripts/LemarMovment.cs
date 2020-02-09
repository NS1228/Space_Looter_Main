using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemarMovment : MonoBehaviour
{
    public float Speed;
    public float Sprint;
    public float Walk;
    public float Crawl;
    public float Thrust = 1.0f;

    public Rigidbody rb;

    public bool Running;
    public bool Walking;
    public bool Crawling;
    public bool Stand;
    public bool Moving;
    public bool Sprinting;

    public GameObject Player;
    public GameObject WNoise;
    public GameObject SNoise;
    public GameObject CNoise;

    public Vector3 curPos;
    public Vector3 lastPos;

    public BoxCollider CrouchSize;
    public CapsuleCollider StandSize;



    void Start()
    {
        Sprint = Speed * 2;
        Walk = Speed * 1;
        Crawl = Speed / 2;
        
        Stand = true;
        Walking = true;

        WNoise.SetActive(false);
        SNoise.SetActive(false);
        CNoise.SetActive(false);

        CrouchSize = GetComponent<BoxCollider>();
        StandSize = GetComponent<CapsuleCollider>();

        rb = GetComponent<Rigidbody>();
    }




    void Update()
    {
        Movement();
        Crouch();
        CrouchSpeed();
        NoiseMaking();

        curPos = transform.position;
        if (curPos == lastPos)
        {
            Moving = false;
        }
        else
        {
            Moving = true;
        }
        lastPos = curPos;
     
    }





    void Movement()
    {
        float horizon = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizon, 0f, verti) * Speed * Time.deltaTime;
        transform.Translate(move, Space.Self);

        if (Stand == true && Input.GetKey(KeyCode.LeftShift))
        {
            Speed = Sprint;
            Running = true;
            Walking = false;
            Sprinting = true;
        }
        else
        {
            Speed = Walk;
            Running = false;
            Sprinting = false;
        }
        if (Stand == true && Input.GetKeyUp(KeyCode.LeftShift))
        {
            Walking = true;
        }
    }





    void Crouch()
    {
        Vector3 v = transform.rotation.eulerAngles;
        Vector3 n = Player.transform.position;
        if (Input.GetKeyUp(KeyCode.C))
        {  
            if (Stand == true)
            {
                Player.transform.rotation = Quaternion.Euler(90, v.y, v.z);
                Stand = false;
                Crawling = true;
                Walking = false;
                Running = false;
                CrouchSize.isTrigger = false;
                StandSize.isTrigger = true;


            }
            else
            {
                {
                    Player.transform.rotation = Quaternion.Euler(0, v.y, v.z);
                    Stand = true;
                    Crawling = false;
                    Walking = true;
                    CrouchSize.isTrigger = true;
                    StandSize.isTrigger = false;
                  
                }
            }
            if (Sprinting == true)
            {
                rb.AddForce(transform.forward * Thrust);
            }

        }
    }







    void CrouchSpeed()
    {
        
        if (Stand == false)
        {
            Speed = Crawl;
        }
    }




    void NoiseMaking()
    {
        if (Moving == true && Walking == true)
        {
            WNoise.SetActive(true);
        }
        else
        {
            WNoise.SetActive(false);
        }

        if (Moving == true && Running == true)
        {
            SNoise.SetActive(true);
        }
        else
        {
            SNoise.SetActive(false);
        }

        if (Moving == true && Crawling == true)
        {
            CNoise.SetActive(true);
        }
        else
        {
            CNoise.SetActive(false);
        }


    }

}



