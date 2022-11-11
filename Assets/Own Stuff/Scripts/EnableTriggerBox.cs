using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTriggerBox : MonoBehaviour
{
    public GameObject Target;

    private void OnTriggerEnter(Collider other)
    {
        Target.SetActive(true);
    }
}
