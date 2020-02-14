using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemarMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool MenuUp = false;

    public GameObject Inventory;

    // Use this for initialization
    void Start()
    {
        Inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (MenuUp)
            {
                Resume();
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

            }
            else
            {

                Menu();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

    }
    void Resume()
    {
        Inventory.SetActive(false);
        Time.timeScale = 1;
        MenuUp = false;
    }
    void Menu()
    {
        Inventory.SetActive(true);
        Time.timeScale = 0;
        MenuUp = true;
    }
}