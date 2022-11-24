using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour
{
    public LayerMask mask;

    private GameObject storedObject;

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity, mask))
        {
            if (hit.collider.gameObject.tag == "LookableObject")
            {
                var obj = hit.collider.gameObject;

                obj.GetComponent<ReplaceOnTrigger>().Trigger();
            }

            if (hit.collider.gameObject.tag == "StencilMaskTriggerBox")
            {
                var obj1 = hit.collider.gameObject;
                storedObject = obj1;

                obj1.GetComponent<MagicBoxItemManager>().SetVisibleItem();
                obj1.GetComponent<MagicBoxItemManager>().DisableOtherBoxSides();
            }
            else if (storedObject != null)
            {
                storedObject.GetComponent<MagicBoxItemManager>().EnableOtherBoxSides();
                storedObject = null;
            }
        }
        else if (storedObject != null)
        {
            storedObject.GetComponent<MagicBoxItemManager>().EnableOtherBoxSides();
            storedObject = null;
        }
    }
}
