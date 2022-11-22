using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIK : MonoBehaviour
{
    [SerializeField] private Transform leftHand;
    [SerializeField] private Transform mainCamera;
    private Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        leftHand.localPosition = new Vector3(0.01080626f, 0.001977066f, -0.005458908f);
        leftHand.localRotation = Quaternion.Euler(-41.417f, 26.251f, -30.595f);
      
   }
 
    private void OnAnimatorIK(int layerIndex)
    {
       
     
        leftHand.localPosition = new Vector3((-mainCamera.localRotation.x / 12), 0.001977066f, -0.005458908f);
        playerAnimator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1);
        playerAnimator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1);
        playerAnimator.SetIKPosition(AvatarIKGoal.LeftHand, leftHand.position);
        playerAnimator.SetIKRotation(AvatarIKGoal.LeftHand, leftHand.rotation);
  
    }
}
