using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttackScript : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private int swordDamage = 100;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ghoul")
        {
            if (playerAnimator.GetCurrentAnimatorStateInfo(1).IsName("DefaultAttack")   
                && !other.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
            {
                other.GetComponent<GhoulClass>().TakeDamage(swordDamage);
              
            }
        }
    }
}
