using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarMCraft : MonoBehaviour
{
    public Text MetalCount;
    public int MNeeded;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MetalCount.text = "x" + MNeeded;
        if (LemarMetal.MetalNumber < MNeeded)
        {
            MetalCount.color = Color.red;
        }
        if (LemarMetal.MetalNumber >= MNeeded)
        {
            MetalCount.color = Color.green;
        }
    }
}
