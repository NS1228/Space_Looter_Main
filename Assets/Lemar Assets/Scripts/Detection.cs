using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;

    public float DetectionLevel;
    public float DetectedNo;

    public float Timer;

    // Start is called before the first frame update
    void Start()
    {
        Level1.SetActive(false);
        Level2.SetActive(false);
        Level3.SetActive(false);
        Level4.SetActive(false);
        Level5.SetActive(false);
        Text1.SetActive(true);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
        Text5.SetActive(false);
        Text6.SetActive(false);

        DetectionLevel = 0;
        DetectedNo = 0;

        Timer = 7;
    }

    // Update is called once per frame
    void Update()
    {
        Alerted();
        Detected();
    }

    void Alerted()
    {
        if (DetectedNo == 0)
        {
            Timer = 7;
        }
        if (DetectedNo <= 2 && DetectedNo > 0)
        {
            Timer -= Time.deltaTime;
        }
        if (DetectedNo >= 3)
        {
            Timer = 0;
        }
    }

    void Detected()
    {
        if (Timer <= 0)
        {
            DetectionLevel++;
            Timer = 7;
            DetectedNo = 0;
        }
        if (DetectionLevel == 0)
        {
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Text1.SetActive(true);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);
        }
        if (DetectionLevel == 1)
        {
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Text1.SetActive(false);
            Text2.SetActive(true);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);

        }
        if (DetectionLevel == 2)
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(true);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(false);

        }
        if (DetectionLevel == 3)
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(true);
            Text5.SetActive(false);
            Text6.SetActive(false);
        }
        if (DetectionLevel == 4)
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(true);
            Level5.SetActive(false);
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(true);
            Text6.SetActive(false);
        }
        if (DetectionLevel == 5)
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(true);
            Level5.SetActive(true);
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(false);
            Text5.SetActive(false);
            Text6.SetActive(true);
        }
        
    }
}
