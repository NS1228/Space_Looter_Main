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

    public int ElementReward;
    public int LiquidReward;
    public int MetalReward;

    public GameObject UniqueItemReward;
    public GameObject ObjectiveItemReward;

    public GameObject GameCamera;
    public GameObject PlayerCamera;
    public GameObject Player;
    public GameObject Game;
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
            Destroy(Game);
            GameCamera.SetActive(false);
            PlayerCamera.SetActive(true);
            Player.GetComponent<LemarMovment>().enabled = true;
            if (Mashnumber >= 0 && Mashnumber < 50 && Playing == true)
            {
                LemarMetal.MetalNumber += MetalReward -= 1;
                LemarLiquid.LiquidNumber += LiquidReward -= 1;
                LemarElement.ElementNumber += ElementReward -= 1;
                Playing = false;
                UniqueItemReward.SetActive(false);
                ObjectiveItemReward.SetActive(true);
            }
            if (Mashnumber >= 50 && Mashnumber < 80 && Playing == true)
            {
                LemarMetal.MetalNumber += MetalReward;
                LemarLiquid.LiquidNumber += LiquidReward;
                LemarElement.ElementNumber += ElementReward;
                Playing = false;
                UniqueItemReward.SetActive(false);
                ObjectiveItemReward.SetActive(true);
            }
            if (Mashnumber >= 80 && Playing == true)
            {
                LemarMetal.MetalNumber += MetalReward += 1;
                LemarLiquid.LiquidNumber += LiquidReward += 1;
                LemarElement.ElementNumber += ElementReward += 1;
                Playing = false;
                UniqueItemReward.SetActive(false);
                ObjectiveItemReward.SetActive(true);
            }
        }
        

    }
}
