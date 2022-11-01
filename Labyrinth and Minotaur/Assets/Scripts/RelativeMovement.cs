using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerRotationHelper : MonoBehaviour
{
    public float rotSpeed = 1.5f;
    private float horInput;
        
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

 
        horInput  = Input.GetAxis("Mouse X") * rotSpeed * 3;

        Quaternion rotation = Quaternion.Euler(0, horInput, 0);

        controller.transform.Rotate(0, horInput, 0);




        /* if (horInput != 0  )
         {
             movement.x = horInput;
             Quaternion tmp = target.rotation;
             target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
             movement = target.TransformDirection(movement);
             target.rotation = tmp;
             transform.rotation = Quaternion.LookRotation(movement);
         }
 }*/
    }
}