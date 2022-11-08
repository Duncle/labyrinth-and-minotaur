using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour
{
    [SerializeField] private Transform target;
     
    public float rotSpeed = 1.5f;
    public static float rotY;
    public static float rotX;
    private float rotYTemp;
    private Vector3 offset;
    public Animator playerAnimator;

    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rotY = transform.eulerAngles.y;
        rotX = transform.eulerAngles.x;
        offset = target.position - transform.position;
    }
    void Update()
    {
       
       
        if (!playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Damage"))
        {
                
        rotX += Input.GetAxis("Mouse X") * rotSpeed * 3;
        rotY += Input.GetAxis("Mouse Y") * -2;

        if (rotY >= 26)
        {
            rotY = 26;
        }
        if (rotY <= -33)
        {
            rotY = -33;
        }
        if (rotY <= 26 && rotY >= -33)
        {
            Quaternion rotation = Quaternion.Euler(rotY, rotX, 0);
            transform.rotation = (rotation);
        }
        rotYTemp = rotY;

        }

    }
 
}