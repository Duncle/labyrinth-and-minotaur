using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GhoulClass : EnemyClass
{
    [SerializeField] private int hitPoint = 100;
    //[SerializeField] private int staminaPoint = 100;
    [SerializeField] private Slider healthBar;
    [SerializeField] private Animator ghoulAnimator;
    public void Start()
    {
        ghoulAnimator = GetComponent<Animator>();
    }
    private void Update()
    {
        healthBar.value = hitPoint;
        if (ghoulAnimator.GetCurrentAnimatorStateInfo(0).IsName("RightHandAttackInterrupts")
           || ghoulAnimator.GetCurrentAnimatorStateInfo(0).IsName("LeftHandAttackInterrupts"))
        {
            ghoulAnimator.ResetTrigger("RightHandAttackInterrupts");
            ghoulAnimator.ResetTrigger("LeftHandAttackInterrupts");

        }
    }
    public void TakeDamage(int weaponDamage)
    {
        hitPoint -= weaponDamage;
        if (hitPoint <= 0)
        {
            GetComponent<GhoulAnimationHelper>().Death();
            healthBar.gameObject.SetActive(false);
            GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            Debug.Log("B123123");
            GetComponent<GhoulAnimationHelper>().GetHit();
        }

    }




}
