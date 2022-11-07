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
    private bool hitGround = false;
    void Start()
    {
        _vertSpeed = minFall;
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        float controllerPositionX = controller.transform.position.x;
        float controllerPositionY = controller.transform.position.y - 0.29f;
        float controllerPositionZ = controller.transform.position.z;
        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        Vector3 rayOutPlayerTansfrom = new Vector3(controllerPositionX, controllerPositionY + 0.8f, controllerPositionZ);
        Vector3 movement = Vector3.zero;

        RaycastHit hit;

        Physics.Raycast(rayOutPlayerTansfrom, Vector3.down, out hit);
        Debug.DrawRay(rayOutPlayerTansfrom, Vector3.down, Color.red);

        if (Physics.Raycast(rayOutPlayerTansfrom, Vector3.down, out hit))
        {
            Debug.Log(hit.collider.gameObject.name);
            hitGround = true;
        }
        else
        {
            hitGround = false;
        }

        controller.transform.Rotate(0, Input.GetAxis("Mouse X") * rotSpeed * 3, 0);
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

        if (hitGround)
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
        else
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
}
