using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarMetal : MonoBehaviour
{
    public Text MetalCount;
    public static int MetalNumber;
    // Start is called before the first frame update
    void Start()
    {
        MetalNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MetalCount.text = "x" + MetalNumber;
    }


}

