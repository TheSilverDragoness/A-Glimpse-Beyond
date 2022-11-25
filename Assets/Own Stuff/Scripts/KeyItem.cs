using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyItem : MonoBehaviour
    {
        [SerializeField]
        private BoxCollider boxCollider;

        [SerializeField]
        private BoxCollider keyPlacementCollider;

        [SerializeField]
        private GameObject[] keyItems;

        [SerializeField]
        private GameObject door;

        [SerializeField]
        private GameObject key;

        private GameObject visibleItem;
        private int originalLayer;
        private bool hasLeftBox;

        private void Start()
        {
            hasLeftBox = false;
        }

        public void SetVisibleItem(GameObject item)
        {
            if (gameObject.GetComponent<Collider>().bounds.Intersects(boxCollider.bounds))
            {
                visibleItem = item;
                //Debug.Log(visibleItem + " is the visible item");
            }
        }

        private void OnTriggerExit(Collider triggerBox)
        {
            //Debug.Log(visibleItem + " left box");
            if (triggerBox == boxCollider && !hasLeftBox)
            {
                //Debug.Log("Item that left box was keyItem");
                originalLayer = visibleItem.layer;
                visibleItem.layer = default;

                foreach (GameObject item in keyItems)
                {
                    if (item != visibleItem)
                    {
                        item.SetActive(false);
                    }
                }

                hasLeftBox = true;
            }

            if (triggerBox == keyPlacementCollider)
            {
                door.GetComponentInChildren<DynamicObject>().LockDoor();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log(visibleItem + " entered box");
            if (other == boxCollider && hasLeftBox)
            {
                //Debug.Log("item that entered box is key item");
                visibleItem.layer = originalLayer;

                foreach (GameObject item in keyItems)
                {
                    item.GetComponent<KeyItemChild>().ResetItem();
                }

                hasLeftBox = false;
            }

            if (other == keyPlacementCollider && key.activeSelf)
            {
                Debug.Log("Item placed on pedestal is key");
                door.GetComponentInChildren<DynamicObject>().UnlockDoor();
            }
        }
    }
}