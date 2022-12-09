using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyDetectorTracker : MonoBehaviour
    {
        //private List<GameObject> boxColliders = new List<GameObject>();
        //[SerializeField]
        //private GameObject[] boxColliders;

        [SerializeField]
        private GameObject keyDetector1;

        [SerializeField]
        private GameObject keyDetector2;

        private bool keyTrigger1 = false;
        private bool keyTrigger2 = false;
        //private bool isUnlocked = true;

        [SerializeField]
        private GameObject door;

        //private void Start()
        //{
        //    foreach (Transform child in this.gameObject.transform)
        //    {
        //        boxColliders.Add(child.gameObject);
        //    }
        //}

        private void Start()
        {
            Debug.Log("keyDetectorTracker initiated");
        }

        private void Update()
        {
            //foreach (GameObject child in boxColliders)
            //{
            //    if (!child.GetComponent<KeyDetector>().IsTriggered)
            //    {
            //        Debug.Log("key detectors not triggered");
            //        isUnlocked = false;
            //    }
            //}

            if (keyDetector1.GetComponent<KeyDetector>().IsTriggered)
            {
                keyTrigger1 = true;
            }

            if (keyDetector2.GetComponent<KeyDetector>().IsTriggered)
            {
                keyTrigger2 = true;
            }

            if (keyTrigger1 && keyTrigger2)
            {
                door.GetComponentInChildren<DynamicObject>().UnlockDoor();
                Debug.Log("door is unlocked");
            }
            else
            {
                Debug.Log("door is locked");
                door.GetComponent<DynamicObject>().LockDoor();
            }

            //if (!isUnlocked)
            //{
            //    door.GetComponentInChildren<DynamicObject>().LockDoor();
            //    //Debug.Log("door is locked");
            //}

            //if (isUnlocked)
            //{
            //    Debug.Log("door is unlocked");
            //    door.GetComponent<DynamicObject>().UnlockDoor();
            //}
        }
    }
}