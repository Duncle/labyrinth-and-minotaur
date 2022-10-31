using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveHelper : MonoBehaviour
{

    private float _vertSpeed;
    public float jumpSpeed = 15.0f;
    public float gravity = -9.8f;
    public float terminalVelocity = -10.0f;
    public float minFall = -1.5f;
    void Start()
    {
        _vertSpeed = minFall;
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal") * 2, 0.0f, Input.GetAxis("Vertical") * 2);

        CharacterController controller = GetComponent<CharacterController>();
        Debug.Log(controller.isGrounded);

        if (controller.isGrounded)
        {

            if (Input.GetButtonDown("Jump"))
            {
                _vertSpeed = jumpSpeed;
            }
            else
            {
                _vertSpeed = minFall;
            }

        }
        if (controller.isGrounded == false)
        {

            _vertSpeed += gravity * 5 * Time.deltaTime;
            if (_vertSpeed < terminalVelocity)
            {
                _vertSpeed = terminalVelocity;
            }

        }
        moveDirection.y = _vertSpeed;


        controller.Move(moveDirection * Time.deltaTime);
    }
}
