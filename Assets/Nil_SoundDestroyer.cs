using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nil_SoundDestroyer : MonoBehaviour
{
    public float destroyTimer;
    // Start is called before the first frame update
    void Start()
    {
        destroyTimer = Time.timeSinceLevelLoad + 8;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyObject();
    }

    void DestroyObject ()
    {
        if(Time.timeSinceLevelLoad >= destroyTimer)
        {
            Destroy(this.gameObject);
        }
    }
}
