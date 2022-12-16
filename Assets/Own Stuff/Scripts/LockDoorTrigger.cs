using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFPS.Systems
{
    public class LockDoorTrigger : MonoBehaviour
    {
        [SerializeField]
        private GameObject door;

        [SerializeField]
        private GameObject[] disableRooms;

        [SerializeField]
        private float delay;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                StartCoroutine(LockDoor());
            }
        }

        IEnumerator LockDoor()
        {
            door.GetComponentInChildren<DynamicObject>().LockDoor();

            yield return new WaitForSecondsRealtime(delay);

            if (disableRooms != null && !door.GetComponentInChildren<DynamicObject>().isOpened)
            {
                foreach (GameObject room in disableRooms)
                {
                    room.SetActive(false);
                }
            }

            door.GetComponentInChildren<DynamicObject>().isLocked = true;

            yield return null;
        }
    }
}