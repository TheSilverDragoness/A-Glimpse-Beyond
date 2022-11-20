using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class ItemDetector : MonoBehaviour
    {
        [SerializeField]
        private GameObject key;

        [SerializeField]
        private GameObject door;


        private void OnTriggerEnter(Collider other)
        {
            if (other == key)
            {
                door.GetComponentInChildren<DynamicObject>().UnlockDoor();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other == key)
            {
                door.GetComponentInChildren<DynamicObject>().LockDoor();
            }
        }
    }
}