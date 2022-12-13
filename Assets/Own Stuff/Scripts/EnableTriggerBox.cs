using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTriggerBox : MonoBehaviour
{
    public GameObject Target;

    [SerializeField]
    private GameObject[] targets;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            foreach (GameObject item in targets)
            {
                item.SetActive(true);
            }
        }
    }
}
