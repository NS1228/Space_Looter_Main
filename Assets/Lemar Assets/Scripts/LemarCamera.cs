using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemarCamera : MonoBehaviour
{
    public float RotateSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotateSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotateSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        if (Input.GetKey(KeyCode.LeftShift))
        {
          Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        }
        else
        {
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
          
           // TorchForPlayer.rotation = Quaternion.Euler(mouseX, mouseY, 0);
        }

    }
}
