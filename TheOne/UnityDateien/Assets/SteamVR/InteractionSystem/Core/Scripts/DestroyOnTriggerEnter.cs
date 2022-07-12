using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem
{
	public class DestroyOnTriggerEnter : MonoBehaviour
	{
		public GameObject toDestroy;

		void OnTriggerEnter( Collider collider )
		{
			Destroy(collider, 0.3f);
			Destroy(toDestroy, 0.5f);		
		}
	}
}
