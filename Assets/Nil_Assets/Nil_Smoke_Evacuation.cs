using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nil_Smoke_Evacuation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "AI")
        {
            other.gameObject.GetComponent<Nil_FOVdetection>().evacuate = true;
        }
    }
}
