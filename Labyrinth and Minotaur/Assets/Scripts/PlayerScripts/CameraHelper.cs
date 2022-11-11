using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour
{
    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;
    [SerializeField] private float mouseSensivity;
    [SerializeField] private float maxUp;
    [SerializeField] private float minUp;
    [SerializeField] private float xRotation;
    public Transform playerTransform;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }
    void Update()
    {
        GetAxis();
        SetMouseRotation();
    }
    void GetAxis()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensivity;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensivity;
    }
    private void SetMouseRotation()
    {
        xRotation    -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation,0  , 0);
        xRotation = Mathf.Clamp(xRotation, (maxUp*-1), (minUp * -1));
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}