using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class MagicBoxItemManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject keyItem;

        [SerializeField]
        private GameObject item;

        [SerializeField]
        private GameObject keyItem1;

        [SerializeField]
        private GameObject item1;

        [SerializeField]
        private GameObject[] otherBoxSides;

        public void SetVisibleItem()
        {
            keyItem.GetComponent<KeyItem>().SetVisibleItem(item);
            keyItem1.GetComponent<KeyItem>().SetVisibleItem(item1);
        }

        public void DisableOtherBoxSides()
        {
            foreach (GameObject boxSide in otherBoxSides)
            {
                boxSide.SetActive(false);
            }
        }

        public void EnableOtherBoxSides()
        {
            foreach (GameObject boxSide in otherBoxSides)
            {
                boxSide.SetActive(true);
            }
        }
    }
}