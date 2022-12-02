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
            if (item.tag == "key")
            {
                IsTriggered = true;
            }
        }

        private void OnTriggerExit(Collider item)
        {
            if (item.tag == "key")
            {
                IsTriggered = false;
            }
        }
    }
}
