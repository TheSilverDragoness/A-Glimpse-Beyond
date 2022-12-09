using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class KeyItemChild : MonoBehaviour
    {
        [HideInInspector]
        public int originalLayer;

        private void Awake()
        {
            originalLayer = gameObject.layer;
        }

        public void ResetItem()
        {
            gameObject.SetActive(true);
            gameObject.layer = originalLayer;
        }
    }
}