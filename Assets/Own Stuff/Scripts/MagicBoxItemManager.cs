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
        Debug.Log(item + " is visible");
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
