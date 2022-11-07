using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helper : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        Debug.DrawRay(transform.position, transform.forward*100f,Color.yellow);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit)){
            hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
