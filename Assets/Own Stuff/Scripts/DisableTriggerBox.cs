using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTriggerBox : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private GameObject[] targets;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject item in targets)
            {
                item.SetActive(false);
            }
        }
    }
}
