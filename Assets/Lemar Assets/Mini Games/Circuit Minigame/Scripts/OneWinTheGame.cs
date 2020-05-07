using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OneWinTheGame : MonoBehaviour
{
    public GameObject Block_One;
    private float Block_One_z;

    public GameObject Block_Two;
    private float Block_Two_z;

    public GameObject Block_Three;
    private float Block_Three_z;

    public GameObject Block_Four;
    private float Block_Four_z;

    public GameObject Block_Five;
    private float Block_Five_z;

    public GameObject Block_Six;
    private float Block_Six_z;

    public GameObject Block_Seven;
    private float Block_Seven_z;

    public GameObject Block_Eight;
    private float Block_Eight_z;

    public GameObject Block_Nine;
    private float Block_Nine_z;

    public GameObject End_Off;
    public GameObject PlayerCam;
    public GameObject Cam;
    public GameObject Puzzle;

    public GameObject UniqueItemReward;
    public GameObject ObjectiveItemReward;

    public int ElementReward;
    public int LiquidReward;
    public int MetalReward;

    public float Timer;
    public Text Timertext;

    public GameObject Player;




    // Start is called before the first frame update
    void Start()
    {
        Timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Block_One_z = Block_One.transform.rotation.eulerAngles.z;
        Block_Two_z = Block_Two.transform.rotation.eulerAngles.z;
        Block_Three_z = Block_Three.transform.rotation.eulerAngles.z;
        Block_Four_z = Block_Four.transform.rotation.eulerAngles.z;
        Block_Five_z = Block_Five.transform.rotation.eulerAngles.z;
        Block_Six_z = Block_Six.transform.rotation.eulerAngles.z;
        Block_Seven_z = Block_Seven.transform.rotation.eulerAngles.z;
        Block_Eight_z = Block_Eight.transform.rotation.eulerAngles.z;
        Block_Nine_z = Block_Nine.transform.rotation.eulerAngles.z;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        int seconds = (int)(Timer % 60);
        int minutes = (int)(Timer / 60) % 60;
        string TimerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        Timertext.text = TimerString;

        CheckIfCorrect();
        Timer += Time.deltaTime;
    }

    

    void CheckIfCorrect()
    {
        
        if (Block_One_z == 0 && Block_Two_z == 180 && Block_Three_z == 0 && Block_Four_z == 180 && (Block_Five_z == 0 || Block_Five_z == 180) && Block_Six_z == 270 && (Block_Seven_z == 90 || Block_Seven_z == 270) && Block_Eight_z == 90 && Block_Nine_z == 0)
        {

            //print("All Good");

            
            Destroy(End_Off);
            PlayerCam.SetActive(true);
            Cam.SetActive(false);
            Destroy(Puzzle);
            Player.GetComponent<LemarMovment>().enabled = true;

            if (Timer > 20)
            {
                LemarMetal.MetalNumber += MetalReward -= 1;
                LemarLiquid.LiquidNumber += LiquidReward -= 1;
                LemarElement.ElementNumber += ElementReward -= 1;
                UniqueItemReward.SetActive(false);
                ObjectiveItemReward.SetActive(true);
            }
            if (Timer < 20 && Timer > 10)
            {
                LemarMetal.MetalNumber += MetalReward;
                LemarLiquid.LiquidNumber += LiquidReward;
                LemarElement.ElementNumber += ElementReward;
                UniqueItemReward.SetActive(false);
                ObjectiveItemReward.SetActive(true);
            }
            if (Timer < 10)
            {
                LemarMetal.MetalNumber += MetalReward += 1;
                LemarLiquid.LiquidNumber += LiquidReward += 1;
                LemarElement.ElementNumber += ElementReward += 1;
                UniqueItemReward.SetActive(false);
                ObjectiveItemReward.SetActive(true);
            
            }
        }



    }
}

