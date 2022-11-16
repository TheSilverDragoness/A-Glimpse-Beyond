using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAt : MonoBehaviour
{
    public LayerMask mask;

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out var hit, Mathf.Infinity, mask))
        {
            var obj = hit.collider.gameObject;

            obj.GetComponent<ReplaceOnTrigger>().Trigger();
        }
    }
}
