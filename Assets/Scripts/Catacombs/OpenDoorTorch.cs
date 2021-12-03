using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HorrorVR
{
    public class OpenDoorTorch : MonoBehaviour
    {
        public GameObject door;

        bool isOpen = false;

        private Quaternion initialRotation;

        // Start is called before the first frame update
        void Start()
        {
            initialRotation = door.transform.rotation;
        }

        private void OnTriggerEnter(Collider other)
        {
            if(isOpen == false)
            {
                StartCoroutine(OpenDoor());
                isOpen = true;
            }
        }

        IEnumerator OpenDoor()
        {
            Quaternion newAngle = Quaternion.Euler(0, initialRotation.y + 90f, 0);
            float startTime = Time.time;

            while(Time.time < startTime + 3f)
            {
                door.transform.rotation = Quaternion.Lerp(initialRotation, newAngle, (Time.time - startTime) / 3f);
                yield return null;
            }
        }
    }
}