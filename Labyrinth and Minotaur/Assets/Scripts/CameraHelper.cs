using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour
{
    [SerializeField] private Transform target;
    public Animator playerAnimator;
    public float rotSpeed = 1.5f;
    private float _rotY;
    private float _rotX;
    private float _rotYTemp;
    private Vector3 _offset;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _rotY = transform.eulerAngles.y;
        _rotX = transform.eulerAngles.x;
        _offset = target.position - transform.position;
    }
    void Update()
    {
        if (!playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("BasicMotions@Jump01 [RM]"))
        {
            _rotX += Input.GetAxis("Mouse X") * rotSpeed * 3;
            _rotY += Input.GetAxis("Mouse Y") * -2;

            if (_rotY >= 26)
            {
                _rotY = 26;
            }
            if (_rotY <= -33)
            {
                _rotY = -33;
            }
            if (_rotY <= 26 && _rotY >= -33)
            {
                Debug.Log("asd");
                Quaternion rotation = Quaternion.Euler(_rotY, _rotX, 0);
                transform.rotation = (rotation);
            }
            _rotYTemp = _rotY;
        }
        else
        {
            Quaternion rotation = Quaternion.Euler(_rotYTemp, _rotX, 0);
            transform.rotation = (rotation);
        }
       
    }
}