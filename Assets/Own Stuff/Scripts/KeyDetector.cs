using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyDetector : MonoBehaviour
    {
        [HideInInspector]
        public bool IsTriggered;

        private void Start()
        {
            IsTriggered = false;
        }

        private void OnTriggerEnter(Collider item)
        {
            Debug.Log("triggerenter " + item);

            if (item.gameObject.CompareTag("key"))
            {
                Debug.Log("key placed on keystand");
                IsTriggered = true;
            }
        }

        private void OnTriggerExit(Collider item)
        {
            Debug.Log("triggerexit " + item);
            if (item.gameObject.CompareTag("key"))
            {
                Debug.Log("key removed from keystand");

                IsTriggered = false;
            }
        }
    }
}
