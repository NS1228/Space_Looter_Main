using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarElement : MonoBehaviour
{
    public Text ElementCount;
    public static int ElementNumber;
    // Start is called before the first frame update
    void Start()
    {
        ElementNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ElementCount.text = "x" + ElementNumber;
    }


}

