using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyDetectorTracker : MonoBehaviour
    {
        //private List<GameObject> boxColliders = new List<GameObject>();
        [SerializeField]
        private GameObject[] boxColliders;

        private bool isUnlocked = true;

        [SerializeField]
        private GameObject door;

        //private void Start()
        //{
        //    foreach (Transform child in this.gameObject.transform)
        //    {
        //        boxColliders.Add(child.gameObject);
        //    }
        //}

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
                Debug.Log("door is locked");
            }

            if (isUnlocked)
            {
                door.GetComponent<DynamicObject>().UnlockDoor();
                Debug.Log("door is unlocked");
            }
        }
    }
}