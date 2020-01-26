using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovementScript : MonoBehaviour
{
    public float MovementSpeed = 7.9f;

    public float Gravity = 13.0f;

    public float Jump = 10.0f;

    private Vector3 V3_move_direction = Vector3.zero;

    private CharacterController Character_Controller;





    // Start is called before the first frame update
    void Start()
    {


        Character_Controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Character_Controller.isGrounded)

        {

            V3_move_direction.x = Input.GetAxis("Horizontal");
            V3_move_direction.y = 0;
            V3_move_direction.z = Input.GetAxis("Vertical");


        }

        else

        {



            V3_move_direction.y -= Gravity * Time.deltaTime;

        }



        if(Character_Controller.isGrounded && Input.GetButton("Jump"))



        {

            V3_move_direction.y = Jump;



        }


        Character_Controller.Move(V3_move_direction);

        }



}
