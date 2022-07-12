using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonBecher : MonoBehaviour
    {
        //public HoverButton hoverButton;

        public GameObject parent, becher;

        public static float distance = 0.0f;

        private Vector3 spawnPos = new Vector3(distance,0,0);

        private void Start()
        {
            Instantiate(becher, spawnPos, Quaternion.identity).transform.SetParent(parent.transform, false);;
        }

        private void OnButtonDown(Hand hand)
        {
            StartCoroutine(spawn());
        }

        private IEnumerator spawn()
        {
            GameObject newBecher =  Instantiate(becher, spawnPos, Quaternion.identity);
            newBecher.transform.SetParent(parent.transform, false);
            
            Rigidbody rigidbody = newBecher.GetComponent<Rigidbody>();
            if (rigidbody != null) {
                rigidbody.isKinematic = false;
            }

             yield return null;
        }

        public void setDistance(float d) {
            distance = d;
            spawnPos = new Vector3(distance, 0, 0);
            spawn();
        }
    }
}
