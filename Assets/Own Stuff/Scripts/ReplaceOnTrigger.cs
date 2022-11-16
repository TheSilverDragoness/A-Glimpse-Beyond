using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceOnTrigger : MonoBehaviour
{
    public GameObject Room1;
    public GameObject Room2;

    public void Trigger()
    {
        Room1.SetActive(false);
        Room2.SetActive(true);
        Destroy(gameObject);
    }
}
