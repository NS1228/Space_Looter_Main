using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INstant_Liban : MonoBehaviour
{



    public int Int_NumberOfTimes;

    public bool BL_Infinite = false;

    public float spawnDelay = 2f;

    public GameObject Gunkspawnee;



    private float LA_nexttime;

    private int LA_countsofar = 0;



    // Start is called before the first frame update
    void Start()
    {



        LA_nexttime = Time.time;


    }



    void Update()
    {


        if (Gunkspawnee != null)



        {

            if (LA_nexttime < Time.time)

            {



                if (BL_Infinite || LA_countsofar < Int_NumberOfTimes)


                {




               GameObject GK = Instantiate(Gunkspawnee, transform.position, transform.rotation);


                    LA_countsofar++;


                    LA_nexttime = Time.time + spawnDelay;


                }



            }



        }


    }
}