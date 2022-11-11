using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTriggerBox : MonoBehaviour
{
    public GameObject Target;

    private void OnTriggerEnter(Collider other)
    {
        Target.SetActive(false);
    }
}
