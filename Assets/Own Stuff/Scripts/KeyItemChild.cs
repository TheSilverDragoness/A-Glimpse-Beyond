using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemChild : MonoBehaviour
{
    [HideInInspector]
    public int OriginalLayer;

    private void Start()
    {
        OriginalLayer = gameObject.layer;
    }
}
