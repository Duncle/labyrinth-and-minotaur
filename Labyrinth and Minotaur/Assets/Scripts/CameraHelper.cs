using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float rotSpeed = 1.5f;
    private float _rotY;
    private float _rotX;
    private Vector3 _offset;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _rotY = transform.eulerAngles.y;
        _rotY = transform.eulerAngles.x;
        _offset = target.position - transform.position;
    }
    void  Update()
    {
        
      
    }
}