using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoggleFix : MonoBehaviour
{
    public GameObject Playercam;
    public GameObject GoggleCam;
    public bool Equipped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CameraFix()
    {
        Playercam.SetActive(true);
        GoggleCam.SetActive(false);
    }
}
