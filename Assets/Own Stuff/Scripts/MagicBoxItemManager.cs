using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBoxItemManager : MonoBehaviour
{
    [SerializeField]
    private GameObject keyItem;

    [SerializeField]
    private GameObject item;

    [SerializeField]
    private GameObject[] otherBoxSides;

    public void SetVisibleItem()
    {
        keyItem.GetComponent<KeyItem>().SetVisibleItem(item);
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
