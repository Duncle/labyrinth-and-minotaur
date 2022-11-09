using UnityEngine;

/* The base item class. All items should derive from this. */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {
    public new string name = "New Item";
    public new string description = "Describe an item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    // Called when the item is pressed in the inventory
    public virtual void Use()
    {
        Debug.Log("Using " + name);
    }
}
