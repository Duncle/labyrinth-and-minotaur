using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GhoulClass : EnemyClass
{
    public int hitPoint = 100;
    public int staminaPoint=100;
    public Slider healthBar;
    private void Update()
    {
        healthBar.value = hitPoint;
       
    }
    public  void TakeDamage(int weaponDamage)
    {
        hitPoint -= weaponDamage;
        if (hitPoint <= 0){
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
