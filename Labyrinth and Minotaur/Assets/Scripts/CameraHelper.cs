using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float rotSpeed = 1.5f;
    private float _rotY;

    private Vector3 _offset;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _rotY = transform.eulerAngles.y;
        _offset = target.position - transform.position;
    }
    void Update()
    {

        _rotY += Input.GetAxis("Mouse X") * rotSpeed * 3;
        Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        transform.position = target.position - (rotation * _offset);
        transform.LookAt(target);
    }
}
