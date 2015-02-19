using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

	public void QuitGame(string quitTheGame){
		Application.Quit();
		Debug.Log("Game has Quit");
	}

	public void ChangeToScene (string sceneToChangeTo) {
		Application.LoadLevel (sceneToChangeTo);
	}
	
}
