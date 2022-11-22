using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulRightHandScript : MonoBehaviour
{
    [SerializeField] private Animator ghoulAnimator;
    [SerializeField] private Animator playerAnimator;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shield")
        {
            if (ghoulAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack1")&& playerAnimator.GetCurrentAnimatorStateInfo(2).IsName("ShieldDefence"))

            {
         
                ghoulAnimator.SetTrigger("RightHandAttackInterrupts");
                
            }
        }

        if (other.tag == "Player")
        {
            if (ghoulAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack1")
                && !other.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("GetHitAndPushToRight")
                && !other.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("GetHitAndPushToLeft"))
            {
                other.GetComponent<PlayerAnimationHelper>().GetHitAndPushToRightAnimation();
            }

        }
    }
}
