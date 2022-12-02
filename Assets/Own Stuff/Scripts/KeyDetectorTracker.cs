using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyDetectorTracker : MonoBehaviour
    {
        private List<GameObject> boxColliders = new List<GameObject>();

        private bool isUnlocked = true;

        [SerializeField]
        private GameObject door;

        private void Start()
        {
            foreach (Transform child in this.gameObject.transform)
            {
                boxColliders.Add(child.gameObject);
            }
        }

        private void Update()
        {
            foreach (GameObject child in boxColliders)
            {
                if (!child.GetComponent<KeyDetector>().IsTriggered)
                {
                    isUnlocked = false;
                }
            }

            if (!isUnlocked)
            {
                door.GetComponent<DynamicObject>().LockDoor();
            }

            if (isUnlocked)
            {
                door.GetComponent<DynamicObject>().UnlockDoor();
            }
        }
    }
}