using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singleton

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Move than one instance");
            return;
        }
        instance = this;
    }

    #endregion
    
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallBack;
    
    public int space = 28;

    public List<Item> items = new List<Item>();

    public bool Add(Item item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= space)
            {
                print("Not enough space!");
                return false;
            }
            items.Add(item);
            
            if (onItemChangedCallBack != null)
                onItemChangedCallBack.Invoke();
        }

        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        
        if (onItemChangedCallBack != null)
            onItemChangedCallBack.Invoke();
    }
}
