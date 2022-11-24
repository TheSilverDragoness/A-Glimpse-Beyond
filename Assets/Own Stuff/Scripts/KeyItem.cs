using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    [SerializeField]
    private BoxCollider boxColllider;

    [SerializeField]
    private GameObject object1;

    [SerializeField]
    private GameObject object2;

    private GameObject visibleItem;
    private int originalLayer;
    private bool hasLeftBox;

    private void Start()
    {
        hasLeftBox = false;
    }

    public void SetVisibleItem(GameObject item)
    {
        if (gameObject.GetComponent<Collider>().bounds.Intersects(boxColllider.bounds))
        {
            visibleItem = item;
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(visibleItem + " left box");
        if (other == boxColllider && !hasLeftBox)
        {
            Debug.Log("Item that left box was keyItem");
            originalLayer = visibleItem.layer;
            visibleItem.layer = default;
            
            Debug.Log("layer " + originalLayer + " has been saved as variable");

            if (visibleItem = object1)
            {
                Debug.Log("object1 has left box");
                object2.SetActive(false);
            }
            else if (visibleItem = object2)
            {
                Debug.Log("object 2 has left box");
                object1.SetActive(false);
            }

            hasLeftBox = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(visibleItem + " entered box");
        if (other == boxColllider && hasLeftBox)
        {
            Debug.Log("item that entered box is key item");
            visibleItem.layer = originalLayer;

            object1.SetActive(true);
            object1.layer = object1.GetComponent<KeyItemChild>().OriginalLayer;
            object2.SetActive(true);
            object2.layer = object2.GetComponent<KeyItemChild>().OriginalLayer;

            //if (visibleItem = object1)
            //{
            //    object2.SetActive(true);
            //}
            //else if (visibleItem = object2)
            //{
            //    object1.SetActive(true);
            //}

            hasLeftBox = false;
        }
    }
}
