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
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Good" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += 0;
            LemarLiquid.LiquidNumber += 1;
            LemarElement.ElementNumber += 1;
            Playing = false;
        }
        if (other.tag == "Great" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += 1;
            LemarLiquid.LiquidNumber += 2;
            LemarElement.ElementNumber += 2;
            Playing = false;
        }
        if (other.tag == "Perfect" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += 2;
            LemarLiquid.LiquidNumber += 3;
            LemarElement.ElementNumber += 3;
            Playing = false;
        }

    }
}
