using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCameraScript : MonoBehaviour
{
   public Transform  mainCamera;
    void  Update()
    {
        transform.LookAt(mainCamera);
    }
}
