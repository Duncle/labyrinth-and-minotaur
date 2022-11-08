using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveHelper : MonoBehaviour
{
    public float rotSpeed = 1.5f;
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
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 movement = Vector3.zero;
        controller.transform.Rotate(0, Input.GetAxis("Mouse X") * rotSpeed * 3, 0);
        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            movement.x = horInput * 1.5f;
            movement.z = vertInput * 1.5f;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement.x = horInput * 4f;
            movement.z = vertInput * 4f;
        }


        movement = controller.transform.TransformDirection(movement);

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
        movement.y = _vertSpeed;

        movement = Vector3.ClampMagnitude(movement, 6f);

        controller.Move(movement * Time.deltaTime);
    }
    public void GetCameraRotationGromEndAnimation()
    {
       CameraHelper.rotX  = UnityEngine.Camera.main.transform.eulerAngles.x;
        CameraHelper.rotY  = UnityEngine.Camera.main.transform.eulerAngles.y;
    }
}
