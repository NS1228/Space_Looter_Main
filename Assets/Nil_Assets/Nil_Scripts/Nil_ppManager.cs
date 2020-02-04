using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class Nil_ppManager : MonoBehaviour
{

   public bool isDisorientated;
   public bool stopDisorientate;
   public float disorientatedTimer;
   public PostProcessingProfile Original;
   public PostProcessingProfile Disoreintate;
   //public PostProcessingProfile MotionBlur;
    // Start is called before the first frame update
    void Start()
    {
        stopDisorientate = true;
    }

    // Update is called once per frame
    void Update()
    {
        StunCheck();
        StunTimer();

        
    }


    void StunCheck ()
    {
        if(this.GetComponent<PostProcessingBehaviour>().profile == Disoreintate)
        {
            isDisorientated = true;
        }
        else
        {
            isDisorientated = false;
        }
    }

    void StunTimer ()
    {
        if(isDisorientated && stopDisorientate)
        {
            disorientatedTimer = Time.timeSinceLevelLoad + 5;
            stopDisorientate = false;
        }

        if(Time.timeSinceLevelLoad >= disorientatedTimer && isDisorientated)
        {
            this.GetComponent<PostProcessingBehaviour>().profile = Original;
            stopDisorientate = true;
        }
    }
}
