using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachment : MonoBehaviour
{
    public GameObject Player;
    public GameObject Torch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindWithTag("Equip");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Torch.transform.parent = Player.transform;
            Torch.transform.localPosition = new Vector3(0.8f, -1f, 0f);
            Torch.transform.localRotation = Quaternion.Euler(0, -90, 0);
        }
    }
}
