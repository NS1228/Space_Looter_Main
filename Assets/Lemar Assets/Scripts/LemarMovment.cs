using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemarMovment : MonoBehaviour
{
    public float Speed;
    public float Sprint;
    public float Walk;
    public float Crawl;

    public bool Running;
    public bool Walking;
    public bool Crawling;
    public bool Stand;
    public bool Moving;

    public GameObject Player;
    public GameObject WNoise;
    public GameObject SNoise;
    public GameObject CNoise;

    public Vector3 curPos;
    public Vector3 lastPos;



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

        if (Stand == true && Input.GetKey(KeyCode.Space))
        {
            Speed = Sprint;
            Running = true;
            Walking = false;
        }
        else
        {
            Speed = Walk;
            Running = false;
        }
        if (Stand == true && Input.GetKeyUp(KeyCode.Space))
        {
            Walking = true;
        }
    }





    void Crouch()
    {
        Vector3 v = transform.rotation.eulerAngles;
        Vector3 n = Player.transform.position;
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (Stand == true)
            {
                Player.transform.rotation = Quaternion.Euler(90, v.y, v.z);
                Stand = false;
                Crawling = true;
                Walking = false;
                Running = false;

            }
            else
            {
                {
                    Player.transform.rotation = Quaternion.Euler(0, v.y, v.z);
                    Stand = true;
                    Crawling = false;
                    Walking = true;
                }
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



