using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceOnTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject room1;
    [SerializeField]
    private GameObject room2;
    [SerializeField]
    private GameObject[] relatedObjects;

    public void Trigger()
    {
        room1.SetActive(false);
        room2.SetActive(true);
        
        foreach (GameObject obj in relatedObjects)
        {
            Destroy(obj);
        }

        Destroy(gameObject);
    }
}
