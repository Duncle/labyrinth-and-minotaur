using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulLeftHandScript : MonoBehaviour
{
    [SerializeField] private Animator ghoulAnimator;
    [SerializeField] private Animator playerAnimator;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Shield")
        {
            if (ghoulAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack1") && playerAnimator.GetCurrentAnimatorStateInfo(2).IsName("ShieldDefence"))

            {
                Debug.Log("a");
                ghoulAnimator.SetTrigger("LeftHandAttackInterrupts");
                
            }
        }

        if (other.tag == "Player")
        {
            if (ghoulAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack1")
                && !other.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("GetHitAndPushToRight")
                && !other.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("GetHitAndPushToLeft"))
            {
                other.GetComponent<PlayerAnimationHelper>().GetHitAndPushToLeftAnimation();
            }

        }
    }
}
