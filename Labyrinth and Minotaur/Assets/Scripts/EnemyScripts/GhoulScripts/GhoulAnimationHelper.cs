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
        Debug.Log("A123123");
        ghoulAnimator.SetTrigger("Gethit");
    }
}
