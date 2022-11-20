using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    [SerializeField]
    private BoxCollider boxColllider;

    [SerializeField]
    private GameObject obj1;

    [SerializeField]
    private GameObject obj2;

    private GameObject visibleItem;
    private int i;

    private void Update()
    {
        if (obj1.GetComponent<Renderer>().isVisible)
        {
            visibleItem = obj1;
        }

        if (obj2.GetComponent<Renderer>().isVisible)
        {
            visibleItem = obj2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(visibleItem + " left box");
        if (other == boxColllider)
        {
            Debug.Log("Item that left box was keyItem");
            i = visibleItem.layer;
            visibleItem.layer = default; 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == boxColllider)
        {
            visibleItem.layer = i;
        }
    }
}
