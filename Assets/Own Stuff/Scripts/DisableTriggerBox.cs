using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTriggerBox : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        target.SetActive(false);
    }
}
