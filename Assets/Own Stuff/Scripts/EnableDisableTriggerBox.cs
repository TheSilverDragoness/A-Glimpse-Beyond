using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableTriggerBox : MonoBehaviour
{
    public GameObject TargetObject;

    void Start()
    {
        TargetObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TargetObject.activeSelf)
        {
            TargetObject.SetActive(false);
        }
        else
        {
            TargetObject.SetActive(true);
        }
    }
}
