using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public GameObject Player;
    public GameObject Cam;
    public GameObject Puzzle;




    // Start is called before the first frame update
    void Start()
    {
        
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



        CheckIfCorrect();
    }

    

    void CheckIfCorrect()
    {

        if (Block_One_z == 0 && Block_Two_z == 180 && Block_Three_z == 0 && Block_Four_z == 180 && (Block_Five_z == 0 || Block_Five_z == 180) && Block_Six_z == 270 && (Block_Seven_z == 90 || Block_Seven_z == 270) && Block_Eight_z == 90 && Block_Nine_z == 0)
        {

            //print("All Good");

            
            Destroy(End_Off);
            Player.SetActive(true);
            Cam.SetActive(false);
            Destroy(Puzzle);


        }



    }
}

