using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nil_SoundFinder : MonoBehaviour
{

    public GameObject Player;
    public GameObject soundLocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider theCollision)
    {
        if(theCollision.gameObject.tag == "Sound" && Player.GetComponent<Nil_FOVdetection>().soundDetected == false && Time.timeSinceLevelLoad >= Player.GetComponent<Nil_FOVdetection>().timeSinceLastSeen)
        {
            Player.GetComponent<Nil_FOVdetection>().soundDetected = true;
            Player.GetComponent<Nil_FOVdetection>().timeSinceLastSeen = Time.timeSinceLevelLoad + 7f;
            Player.GetComponent<Nil_FOVdetection>().soundInvestigateTimer = Time.timeSinceLevelLoad + 2;
            Player.GetComponent<Nil_FOVdetection>().moveToDestroyTimer = Time.timeSinceLevelLoad + 7f;
            Instantiate(soundLocation, Player.transform.position, Player.transform.rotation);

            Player.GetComponent<Nil_FOVdetection>().destroyMoveTo = true;
        }
    }
}
