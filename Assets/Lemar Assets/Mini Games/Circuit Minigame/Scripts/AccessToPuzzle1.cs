using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccessToPuzzle1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                Cam.SetActive(true);
                Player.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }
}
