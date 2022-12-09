using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBoxSideManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] otherBoxSides;

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
