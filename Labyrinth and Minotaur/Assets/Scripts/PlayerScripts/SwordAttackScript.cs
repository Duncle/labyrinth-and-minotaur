using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackScript : MonoBehaviour
{
    int swordDamage = 10;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ghoul")
        {
            Debug.Log("C123123"); 
            other.GetComponent<GhoulClass>().TakeDamage(swordDamage );   
        }
    }
}
