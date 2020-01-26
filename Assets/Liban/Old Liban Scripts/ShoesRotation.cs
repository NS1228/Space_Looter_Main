using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoesRotation : MonoBehaviour
{


    public float rotationspeed = 3.7f;


  




    void Update()


    {


        transform.Rotate(new Vector3 (0, 0, 20) * Time.deltaTime);


    }


    }