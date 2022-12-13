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

            yield return new WaitForSecondsRealtime(1);

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