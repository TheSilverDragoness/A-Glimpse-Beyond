using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyDetectorTracker : MonoBehaviour
    {
        [SerializeField]
        private GameObject keyDetector1;

        [SerializeField]
        private GameObject keyDetector2;

        [SerializeField]
        private GameObject door;

        private void Start()
        {
            Debug.Log("keyDetectorTracker initiated");
        }

        private void Update()
        {
            if (keyDetector1.GetComponent<KeyDetector>().IsTriggered && keyDetector2.GetComponent<KeyDetector>().IsTriggered)
            {
                door.GetComponentInChildren<DynamicObject>().UnlockDoor();
                Debug.Log("door is unlocked");
            }

            if (!keyDetector1.GetComponent<KeyDetector>().IsTriggered || !keyDetector2.GetComponent<KeyDetector>().IsTriggered)
            {
                if (!door.GetComponentInChildren<DynamicObject>().isLocked)
                {
                    Debug.Log("door is locked");
                    door.GetComponentInChildren<DynamicObject>().LockDoor();
                }
            }
        }
    }
}