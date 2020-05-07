using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarEquip : MonoBehaviour
{
    public GameObject EquipIcon;
    public bool UnEquipped;
    public GameObject EquippedGadget;
    public static bool GotGadget;
// Start is called before the first frame update
 void Start()
 {
    EquipIcon.SetActive(false);
    UnEquipped = true;
 }

 void Update()
 {

 }






 public void EquipGadget()
 {
    if (UnEquipped && GotGadget == false)
    {
       
        EquipIcon.SetActive(true);
        UnEquipped = false;
        EquippedGadget.SetActive(true);
        GotGadget = true;

    }
    else if (UnEquipped == false && GotGadget)
    {
        EquipIcon.SetActive(false);
        UnEquipped = true;
        EquippedGadget.SetActive(false);
        GotGadget = false;
    }
  }
}