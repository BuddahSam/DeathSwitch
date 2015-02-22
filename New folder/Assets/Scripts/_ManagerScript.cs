using UnityEngine;
using System.Collections;

public class _ManagerScript : MonoBehaviour {


	// Used to quite game
	public void QuitGame(string quitTheGame){
		Application.Quit();
		Debug.Log("Game has Quit");
	}

	//Used to change to selected Level
	public void ChangeToScene (string sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
	
}

