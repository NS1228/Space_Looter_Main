using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Nil_DroneStun : MonoBehaviour
{
    public PostProcessingProfile Original;
    public PostProcessingProfile Disoreintate;

    public GameObject mainCam;
    public GameObject Player;

    public bool canStun;
    public float stunTimer;

    // Start is called before the first frame update
    void Start()
    {
        mainCam.GetComponent<PostProcessingBehaviour>().profile = Original;
        canStun = true;
    }

    // Update is called once per frame
    void Update()
    {
        StunPlayer();
    }


    void StunPlayer ()
    {
        float distance = Vector3.Distance(this.transform.position, Player.transform.position);

        if(distance <= 10f && Nil_Drone_Movement.droneCanAttack)
        {
            if (canStun && Time.timeSinceLevelLoad >= stunTimer)
            {
                mainCam.GetComponent<PostProcessingBehaviour>().profile = Disoreintate;
                stunTimer = Time.timeSinceLevelLoad + 10;
            }
        }
    }
}
