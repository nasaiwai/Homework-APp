/*
 * author: Nasa Iwai
 * date: November 10th, 2016
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ConnectScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
		
	public void NextStage (int stage) {
		SceneManager.LoadScene (stage);
	}

	public void PreviousStage (int stage) {
		SceneManager.LoadScene (stage - 2);
	}

	public void SignUp () {
		SceneManager.LoadScene (8);
	}

	public void Login () {
		SceneManager.LoadScene (7);
	}
}

