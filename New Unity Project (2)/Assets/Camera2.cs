using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
   
     private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }
  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);

            Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
        
    }
}
