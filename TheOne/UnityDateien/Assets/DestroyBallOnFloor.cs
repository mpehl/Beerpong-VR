using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	public class DestroyBallOnFloor : MonoBehaviour
	{
		public GameObject toDestroy;

		void OnTriggerEnter(Collider collider)
		{
			if(collider.CompareTag("Floor")) {
				Destroy(toDestroy, 0.5f);
			}	
		}
	}
}
