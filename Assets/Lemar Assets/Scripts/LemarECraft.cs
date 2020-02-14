using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarECraft : MonoBehaviour
{
    public Text ElementCount;
    public int ENeeded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ElementCount.text = "x" + ENeeded;
        if (LemarElement.ElementNumber < ENeeded)
        {
            ElementCount.color = Color.red;
        }
        if (LemarElement.ElementNumber >= ENeeded)
        {
            ElementCount.color = Color.green;
        }
    }
}
