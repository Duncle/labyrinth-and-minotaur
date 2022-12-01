using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    public Sprite armorImg;
    public Sprite weaponImg;
    
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Transform parentBeforeDrag;

    public void OnBeginDrag(PointerEventData eventData)
        {
            parentBeforeDrag = transform.parent;
            parentAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            image.raycastTarget = false;
            
            //Update equip slots sprites without an item in it
            if (parentBeforeDrag.parent.tag == "ArmorSlot")
            {
                Transform newCurrentItemImg = Object.Instantiate(transform, transform, true);
                newCurrentItemImg.GetComponent<Image>().sprite = armorImg;
                newCurrentItemImg.SetParent(parentBeforeDrag);
            }
            else if (parentBeforeDrag.parent.tag == "WeaponSlot")
            {
                Transform newCurrentItemImg = Object.Instantiate(transform, transform, true);
                newCurrentItemImg.GetComponent<Image>().sprite = weaponImg;
                newCurrentItemImg.SetParent(parentBeforeDrag);
            }
            else
            {
                Transform newCurrentItemImg = Object.Instantiate(transform, transform, true);
                newCurrentItemImg.GetComponent<Image>().sprite = null;
                newCurrentItemImg.SetParent(parentBeforeDrag);
            }
        }
    
        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }
    
        public void OnEndDrag(PointerEventData eventData)
        {
            if (parentAfterDrag.GetChild(0).GetComponent<Image>().sprite == null)
            {
                transform.SetParent(parentAfterDrag);
                image.raycastTarget = true;
                if (parentAfterDrag.childCount > 1)
                {
                    GameObject.Destroy(parentAfterDrag.GetChild(0).gameObject);
                }
            }
            else if (parentAfterDrag.parent.CompareTag("ArmorSlot") || parentAfterDrag.parent.CompareTag("WeaponSlot"))
            {
                transform.SetParent(parentAfterDrag);
                image.raycastTarget = true;
                if (parentAfterDrag.childCount > 1)
                {
                    GameObject.Destroy(parentAfterDrag.GetChild(0).gameObject);
                }
            }
            else
            {
                transform.SetParent(parentBeforeDrag);
                image.raycastTarget = true;
                if (parentBeforeDrag.childCount > 1)
                {
                    GameObject.Destroy(parentBeforeDrag.GetChild(0).gameObject);
                }
            }
        }
}
