using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        GetComponent<Rigidbody>().velocity = new Vector3(-3, 0, 0);

        

        
    }
}
