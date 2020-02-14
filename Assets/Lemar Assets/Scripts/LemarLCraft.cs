using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarLCraft : MonoBehaviour
{
    public Text LiquidCount;
    public int LNeeded;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LiquidCount.text = "x" + LNeeded;
        if (LemarLiquid.LiquidNumber < LNeeded)
        {
            LiquidCount.color = Color.red;
        }
        if (LemarLiquid.LiquidNumber >= LNeeded)
        {
            LiquidCount.color = Color.green;
        }
    }
}
