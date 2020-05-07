using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameTiming : MonoBehaviour
{
    public GameObject Game;
    public GameObject GameCamera;
    public GameObject PlayerCamera;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.G))
        {
            Game.SetActive(true);
            GameCamera.SetActive(true);
            PlayerCamera.SetActive(false);
            Player.GetComponent<LemarMovment>().enabled = false;
        }
    }
}
