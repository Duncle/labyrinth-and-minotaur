using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulMoveScript : MonoBehaviour
{
    [SerializeField] private Collider ghoulCollider;
    [SerializeField] private bool isGrounded;

    [SerializeField] private float _vertSpeed;
    [SerializeField] private float gravity = -9.8f;
    [SerializeField] private float terminalVelocity = -10.0f;
    [SerializeField] private float ghoulLocalPositionX;
    [SerializeField] private float ghoulLocalPositionY;
    [SerializeField] private float ghoulLocalPositionZ;
    void Start()
    {
        ghoulCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        ghoulLocalPositionX = ghoulCollider.transform.position.x;
        ghoulLocalPositionY = ghoulCollider.transform.position.y;
        ghoulLocalPositionZ = ghoulCollider.transform.position.z;

        Vector3 movement = Vector3.zero;
        movement = ghoulCollider.transform.TransformDirection(movement);
       
       
        RaycastHit hit;
        Physics.Raycast(new Vector3(ghoulLocalPositionX,ghoulLocalPositionY+0.6f,ghoulLocalPositionZ), new Vector3(0, -0.6f, 0),out hit, 0.6f, LayerMask.GetMask("Ground"));
  
        if (hit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;

        }
        if (isGrounded == false)
        {

            _vertSpeed  = gravity  * Time.deltaTime;
            if (_vertSpeed < terminalVelocity)
            {
                _vertSpeed = terminalVelocity;
            }

        }
        
        movement.y = _vertSpeed;

        movement = Vector3.ClampMagnitude(movement, 6f);

        ghoulCollider.GetComponent<Rigidbody>().AddForce(movement, ForceMode.Impulse);
    }
}
