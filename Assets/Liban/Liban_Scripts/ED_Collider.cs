using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ED_Collider : MonoBehaviour
{


    public GameObject ThAPlayer;

    public GameObject ElecPos;


    public GameObject ElecDevice;


    public GameObject NewSphere;


    private float EDTimer;






  



    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == ("Character"))


        {


           



            ElecDevice.transform.SetParent(ElecPos.transform);



           // ElecDevice.transform.position = ElecPos.transform.position;



          //  NewSphere.GetComponent<SphereCollider>().center = new Vector3(0, 0, -4);




            print("gotcha");



        }

    }
}


