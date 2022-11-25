using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Transform parentBeforeDrag;

    public void OnBeginDrag(PointerEventData eventData)
        {
            //Debug.Log("BeginDrag");
            parentBeforeDrag = transform.parent;
            parentAfterDrag = transform.parent;
            //print("Родитель: " + parentAfterDrag);
            //print("Старший родитель: " + parentAfterDrag.parent);
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            image.raycastTarget = false;
            
            print(parentBeforeDrag.tag);
            Transform newCurrentItemImg = Object.Instantiate(transform, transform, true);
            newCurrentItemImg.GetComponent<Image>().sprite = null;
            newCurrentItemImg.SetParent(parentBeforeDrag);
        }
    
        public void OnDrag(PointerEventData eventData)
        {
            //Debug.Log("Dragging");
            transform.position = Input.mousePosition;
        }
    
        public void OnEndDrag(PointerEventData eventData)
        {
            
            transform.SetParent(parentAfterDrag);
            
            image.raycastTarget = true;
            if (parentAfterDrag.childCount > 1)
            {
                GameObject.Destroy(parentAfterDrag.GetChild(0).gameObject);
            }
        }
}
