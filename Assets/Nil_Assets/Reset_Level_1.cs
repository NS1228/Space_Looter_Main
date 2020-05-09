using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_Level_1 : MonoBehaviour
{

    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "AI")
        {
            health = 0;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
