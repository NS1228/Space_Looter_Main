using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LemarEquip : MonoBehaviour
{

    public GameObject EquipIcon;
    public bool Equipped;
    public GameObject Gadget;
    public GameObject EquippedGadget;

    //Liban Torch pick up


    public Transform TorchPosition;

    public Transform Characteryeah;


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
            Destroy(EquippedGadget);

        }
        else
        {

            EquipIcon.SetActive(true);
            Equipped = true;
            EquippedGadget = Instantiate(Gadget, TorchPosition.position, TorchPosition.rotation);

            Gadget.transform.position = TorchPosition.transform.position;

            Gadget.transform.position = new Vector3(0.895487f, -0.0999999f, 0.4122235f);

        }
    }
}
