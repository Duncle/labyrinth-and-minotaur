using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryBtn : MonoBehaviour, IDropHandler
{
    public Image img;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
        draggableItem.parentAfterDrag = transform;
    }
}
