using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nil_Stun_Grenade : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider theCollision)
    {
        if (theCollision.gameObject.tag == "AI")
        {
           theCollision.gameObject.GetComponent<Nil_FOVdetection>().stunned = true;

        }
    
    }
}
