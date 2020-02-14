using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemarCraft : MonoBehaviour
{
    public int ENeeded;
    public int LNeeded;
    public int MNeeded;

    public GameObject Gadget;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Craft()
    {
        if (LemarMetal.MetalNumber >= MNeeded && LemarLiquid.LiquidNumber >= LNeeded && LemarElement.ElementNumber >= ENeeded)
        {
            Gadget.SetActive(true);
            LemarMetal.MetalNumber -= MNeeded;
            LemarLiquid.LiquidNumber -= LNeeded;
            LemarElement.ElementNumber -= ENeeded;
        }
    }
}
