using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Transform[] Points;
    public float moveSpeed;
    private int currentPoint;
    public bool Playing;
    public float Timer;
    public GameObject Game;

    public int ElementReward;
    public int LiquidReward;
    public int MetalReward;

    public GameObject UniqueItemReward;
    public GameObject ObjectiveItemReward;

    public GameObject GameCamera;
    public GameObject PlayerCamera;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[0].position;
        currentPoint = 0;
        Playing = true;
        Timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == Points[currentPoint].position)
        {
            currentPoint++;
        }

        if (currentPoint >= Points.Length)
        {
            currentPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, Points[currentPoint].position, moveSpeed * Time.deltaTime);

        if (Playing == false)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0)
        {
            Destroy(Game);
            GameCamera.SetActive(false);
            PlayerCamera.SetActive(true);
            Player.GetComponent<LemarMovment>().enabled = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Good" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += MetalReward -=1;
            LemarLiquid.LiquidNumber += LiquidReward -=1;
            LemarElement.ElementNumber += ElementReward -=1;
            Playing = false;
            UniqueItemReward.SetActive(false);
            ObjectiveItemReward.SetActive(true);
        }
        if (other.tag == "Great" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += MetalReward;
            LemarLiquid.LiquidNumber += LiquidReward;
            LemarElement.ElementNumber += ElementReward;
            Playing = false;
            UniqueItemReward.SetActive(false);
            ObjectiveItemReward.SetActive(true);
        }
        if (other.tag == "Perfect" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += MetalReward += 1;
            LemarLiquid.LiquidNumber += LiquidReward += 1;
            LemarElement.ElementNumber += ElementReward += 1;
            Playing = false;
            UniqueItemReward.SetActive(false);
            ObjectiveItemReward.SetActive(true);
        }

    }
}
