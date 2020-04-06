using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nil_Playerhealth : MonoBehaviour
{

    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <=0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
