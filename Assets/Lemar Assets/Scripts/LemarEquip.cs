using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarEquip : MonoBehaviour
{
    public GameObject EquipIcon;
public bool Equipped;
public GameObject EquippedGadget;
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
        EquippedGadget.SetActive(false);

    }
    else
    {

        EquipIcon.SetActive(true);
        Equipped = true;
        EquippedGadget.SetActive(true);

    }
}
}