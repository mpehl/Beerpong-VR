using UnityEngine;
using System.Collections;
using Valve.VR;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem.Sample
{
	public class MenuScript : MonoBehaviour
	{
		ButtonBecher btnBecher;

		void Start() {
			btnBecher = GameObject.FindGameObjectWithTag("Balls").GetComponent<ButtonBecher>();
		}

		public void ResetGame( Hand hand )
		{
			resetScene();
		}


		public void EasyMode( Hand hand )
		{
			print("EasyMode");
			btnBecher.setDistance(-0.5f);
			resetScene();
		}


		public void NormalMode( Hand hand )
		{
			print("NormalMode");
			btnBecher.setDistance(0.0f);
			resetScene();
		}


		public void QuitGame( Hand hand )
		{
			print("Quit");
			Application.Quit();
		}

		private void resetScene(){
			SceneManager.LoadScene("GameScene");
		}
	}
}
