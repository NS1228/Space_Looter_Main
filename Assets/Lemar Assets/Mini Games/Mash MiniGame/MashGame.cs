using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MashGame : MonoBehaviour
{
    public float Mashnumber;
    public Text Mashcount;
    public Text Timertext;
    public bool Switch;
    public float Timer;
    public bool Playing;
    // Start is called before the first frame update
    void Start()
    {
        Switch = true;
        Playing = true;
        Timer = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        Mashcount.text = "x" + Mashnumber;
        Mash();
        Endgame();


        int seconds = (int)(Timer % 60);
        int minutes = (int)(Timer / 60) % 60;


        string TimerString = string.Format("{0:00}:{1:00}", minutes, seconds);

        Timertext.text = TimerString;
    }

    void Mash()
    {
        if (Playing == true)
        {
            if (Switch == true && Input.GetKeyUp(KeyCode.E))
            {
                Switch = false;
                Mashnumber++;
            }
            if (Switch == false && Input.GetKeyUp(KeyCode.F))
            {
                Switch = true;
                Mashnumber++;
            }
        }
    }
    void Endgame()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0)
        {
           
            if (Mashnumber >= 0 && Mashnumber < 50 && Playing == true)
            {
                LemarMetal.MetalNumber += 1;
                Playing = false;
            }
            if (Mashnumber >= 50 && Mashnumber < 80 && Playing == true)
            {
                LemarMetal.MetalNumber += 2;
                Playing = false;
            }
            if (Mashnumber >= 80 && Playing == true)
            {
                LemarMetal.MetalNumber += 3;
                Playing = false;
            }
        }
        
    }
}
