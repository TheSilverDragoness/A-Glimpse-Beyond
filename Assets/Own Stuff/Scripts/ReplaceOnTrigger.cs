using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceOnTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enableRooms;

    [SerializeField]
    private GameObject[] disableRooms;

    [SerializeField]
    private GameObject[] relatedObjects;

    public void Trigger()
    {
        if (enableRooms != null)
        {
            foreach (GameObject room in enableRooms)
            {
                room.SetActive(true);
            }
        }

        if (disableRooms != null)
        {
            foreach (GameObject room in disableRooms)
            {
                room.SetActive(false);
            }
        }
        
        foreach (GameObject obj in relatedObjects)
        {
            Destroy(obj);
        }

        Destroy(gameObject);
    }
}
