using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarEquip : MonoBehaviour
{

    public GameObject EquipIcon;
    public bool Equipped;
    // Start is called before the first frame update
    void Start()
    {
        EquipIcon.SetActive(false);
    }

    void Update()
    {
       
    }






    public void EquipGadget()
    {
        if (Equipped)
        {
            EquipIcon.SetActive(false);
            Equipped = false;

        }
        else
        {

            EquipIcon.SetActive(true);
            Equipped = true;

        }
    }
}
