using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public Transform[] Points;
    public float moveSpeed;
    private int currentPoint;
    public bool Playing;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Points[0].position;
        currentPoint = 0;
        Playing = true;
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
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Good" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += 1;
            Playing = false;
        }
        if (other.tag == "Great" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += 2;
            Playing = false;
        }
        if (other.tag == "Perfect" && Input.GetKey(KeyCode.F) && Playing == true)
        {
            moveSpeed = 0;
            LemarMetal.MetalNumber += 3;
            Playing = false;
        }

    }
}
