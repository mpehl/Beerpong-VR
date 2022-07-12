using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ButtonBall : MonoBehaviour
    {
        public HoverButton hoverButton;

        public GameObject parent, ball;

        private Vector3 spawnPos = new Vector3(-0.155f,0,0);

        private void Start()
        {
            hoverButton.onButtonDown.AddListener(OnButtonDown);
            Instantiate(ball, spawnPos, Quaternion.identity).transform.SetParent(parent.transform, false);;
        }

        private void OnButtonDown(Hand hand)
        {
            StartCoroutine(spawn());
        }

        private IEnumerator spawn()
        {
            GameObject newBall =  Instantiate(ball, spawnPos, Quaternion.identity);
            newBall.transform.SetParent(parent.transform, false);
            
            Rigidbody rigidbody = newBall.GetComponent<Rigidbody>();
            if (rigidbody != null) {
                rigidbody.isKinematic = false;
            }

             yield return null;
        }
    }
}