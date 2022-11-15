using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhoulAnimationHelper : MonoBehaviour
{
    private Animator ghoulAnimator;
    public void Start()
    {
        ghoulAnimator = GetComponent<Animator>();
    }
    public void GetHit()
    {
        ghoulAnimator.SetTrigger("GetHit");
    }
    public void Death()
    {

        ghoulAnimator.SetTrigger("Death");

    }
}
