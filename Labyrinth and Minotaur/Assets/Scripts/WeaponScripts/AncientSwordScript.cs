using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AncientSwordScript : MonoBehaviour
{
    [SerializeField] private int damage = 20;
    private CharacterController playerController;
    public void Start()
    {
        playerController = FindObjectOfType<CharacterController>();
    }
    public void OnTriggerEnter(Collider other)
    {
        playerController.GetComponent<PlayerAttackScript>().makeASwordAttack(other,damage);
    }
}
