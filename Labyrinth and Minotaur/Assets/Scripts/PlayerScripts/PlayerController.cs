using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float rotSpeed = 1.5f;
    [SerializeField] private float _vertSpeed;
    [SerializeField] private float jumpSpeed = 15.0f;
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float terminalVelocity = -10.0f;
    [SerializeField] private float minFall = -1.5f;
    [SerializeField] private Camera _camera;
    [SerializeField] private float playerLocalPositionX;
    [SerializeField] private float playerLocalPositionY;
    [SerializeField] private float playerLocalPositionZ;
    [SerializeField] private bool isGrounded;
    void Start()
    {
        _vertSpeed = minFall;
        _camera = Camera.main;
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 movement = Vector3.zero;

        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        playerLocalPositionX = controller.transform.position.x;
        playerLocalPositionY = controller.transform.position.y;
        playerLocalPositionZ = controller.transform.position.z;
        RaycastHit hit;
        Physics.Raycast(new Vector3(playerLocalPositionX, playerLocalPositionY + 0.6f, playerLocalPositionZ), new Vector3(0, -0.7f, 0), out hit, 0.7f, LayerMask.GetMask("Ground"));
        Debug.DrawRay(new Vector3(playerLocalPositionX, playerLocalPositionY + 0.6f, playerLocalPositionZ), new Vector3(0, -0.7f, 0), Color.green);

        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;

        }
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



        if (isGrounded)
        {

            if (Input.GetButtonDown("Jump"))
            {
                GetComponent<PlayerAnimationHelper>().MakeJump();
                _vertSpeed = jumpSpeed;
            }
            else
            {
                _vertSpeed = minFall;
            }

        }
        if (!isGrounded)
        {

            _vertSpeed += gravity * 5 * Time.deltaTime;
            if (_vertSpeed < terminalVelocity)
            {
                _vertSpeed = terminalVelocity;
            }

        }


        movement.y = _vertSpeed;

        movement = Vector3.ClampMagnitude(movement, 6f);

        movement = controller.transform.TransformDirection(movement);

        controller.Move(movement * Time.deltaTime);

    }
}
