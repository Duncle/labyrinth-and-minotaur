using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    public void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }
    public void Update()
    {
         if (Input.GetMouseButton(0))
        {
            GetComponent<PlayerAnimationHelper>().SwordAttackAniamtion();   
        } 
    }
    public void makeASwordAttack(Collider enemyCollider, int damage)
    {
       
        if (enemyCollider.tag == "Ghoul")
        {
          
            if (playerAnimator.GetCurrentAnimatorStateInfo(1).IsName("SwordAttack")
                && !enemyCollider.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("GetHit"))
            {
                enemyCollider.GetComponent<GhoulClass>().TakeDamage(damage);

            }
        }
    }
}
