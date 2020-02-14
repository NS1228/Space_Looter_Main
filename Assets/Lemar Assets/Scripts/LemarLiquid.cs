using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarLiquid : MonoBehaviour
{
    public Text LiquidCount;
    public static int LiquidNumber;
    // Start is called before the first frame update
    void Start()
    {
        LiquidNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LiquidCount.text = "x" + LiquidNumber;
    }

  
}

