using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qwe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void FixedUpdate()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Collider c = GetComponent<Collider>();

        if (rigidbody.transform.position.y < 0)
        {
     
            rigidbody.AddForce(transform.up*transform.localScale*10f, ForceMode.Impulse);
        }
    }
}
