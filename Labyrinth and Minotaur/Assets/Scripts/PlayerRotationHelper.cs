using UnityEngine;
using System.Collections;
public class RelativeMovement : MonoBehaviour
{
    public float rotSpeed = 0.1f;
    public float moveSpeed = 6.0f;
    [SerializeField] private Transform target;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 movement = Vector3.zero;
        target.Rotate(0, Input.GetAxis("Mouse X") * rotSpeed * 3, 0);
        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
 
            movement.x = horInput  ;
            movement.z = vertInput ;
   
         
            movement = target.TransformDirection(movement);
          
         

 

        movement = Vector3.ClampMagnitude(movement, moveSpeed);

        movement *= Time.deltaTime;
        controller.Move(movement);
    }
}