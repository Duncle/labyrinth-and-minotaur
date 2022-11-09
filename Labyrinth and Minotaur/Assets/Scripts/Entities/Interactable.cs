using System;
using UnityEngine;

/*	
	This component is for all objects that the player can
	interact with such as enemies, items etc. It is meant
	to be used as a base class.
*/

public class Interactable : MonoBehaviour
{
    public float interactionRadius = 3f;
    public Transform interactionTransofrm;

    private bool isFocus = false;
    Transform player;

    private bool _hasInteracted = false;

    public virtual void Interact()
    {
        // This method is meant to be overwritten
        Debug.Log("Interacting with " + transform.name);
    }
    
    private void Update()
    {
        if (isFocus && !_hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransofrm.position);

            if (distance <= interactionRadius)
            {
                Interact();
                _hasInteracted = true;
            }
        }
    }
    
    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        _hasInteracted = false;
    }

    // Called when the object is no longer focused
    public void OnDefocused ()
    {
        isFocus = false;
        player = null;
        _hasInteracted = false;
    }
}
