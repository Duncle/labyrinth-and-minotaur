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
    [SerializeField] private Transform playerTransform;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerTransform = FindObjectOfType<CharacterController>().GetComponent<Transform>();

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
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        xRotation = Mathf.Clamp(xRotation, (maxUp ), (minUp));
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}