using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulDamageScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("asdas");
        }
    }
}
