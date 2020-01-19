using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemarMovment : MonoBehaviour
{
    public float Speed;
    public float Sprint;
    public float Walk;
    // Start is called before the first frame update
    void Start()
    {
        Sprint = Speed * 2;
        Walk = Speed * 1;
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }
    void Movement()
    {
        float horizon = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(horizon, 0f ,verti) * Speed * Time.deltaTime;
        transform.Translate(move, Space.Self);

        if (Input.GetKey(KeyCode.Space))
        {
            Speed = Sprint;
        }
        else
        {
            Speed = Walk;
        }
    }
}
