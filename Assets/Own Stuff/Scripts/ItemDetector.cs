using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class ItemDetector : MonoBehaviour
    {
        public GameObject key;

        [SerializeField]
        private GameObject door;


        private void OnTriggerEnter(Collider placedItem)
        {
            if (key.transform.parent == placedItem)
            {
                Debug.Log("Item placed on pedestal is key");
                door.GetComponentInChildren<DynamicObject>().UnlockDoor();
            }
        }

        private void OnTriggerExit(Collider placedItem)
        {
            if (placedItem == key)
            {
                door.GetComponentInChildren<DynamicObject>().LockDoor();
            }
        }
    }
}