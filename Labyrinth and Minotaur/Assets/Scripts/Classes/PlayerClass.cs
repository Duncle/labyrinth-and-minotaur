using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass
{
    private int hitPoint = 20; 
    private int manaPoint;
    private List<Weapon> Inventory;

public void TakeDamage(int damageAmount)
    {
        hitPoint -= damageAmount;
        if (hitPoint <= 0)
        {

        }
    }
}
