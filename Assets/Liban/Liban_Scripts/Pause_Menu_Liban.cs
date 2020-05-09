using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu_Liban : MonoBehaviour
{

    public bool isThePauseMenuOn;

    public GameObject PauseMenuu;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {





        if (Input.GetKeyDown(KeyCode.P))


        {


            isThePauseMenuOn = !isThePauseMenuOn;


        }







        if(isThePauseMenuOn)


        {




            PauseMenuu.SetActive(true);


            Time.timeScale = 0;


            LemarCamera HJUYP = GameObject.FindWithTag("MainCamera").GetComponent<LemarCamera>();

            HJUYP.RotateSpeed = 0;


        }


        else





        {



            PauseMenuu.SetActive(false);

            Time.timeScale = 1;


            LemarCamera HJUPYT = GameObject.FindWithTag("MainCamera").GetComponent<LemarCamera>();

            HJUPYT.RotateSpeed = 10;

        }



    }
}
