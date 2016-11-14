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

	/* Go to the next stage 
     * int stage containts the current stage
	 */
	public void NextStage (int stage) {
		SceneManager.LoadScene (stage);
	}

	/* Go to the previous stage
	 * int stage contains the current stage
	 */
	public void PreviousStage (int stage) {
		SceneManager.LoadScene (stage - 2);
	}

	/* Go to sign up page */
	public void SignUp () {
		SceneManager.LoadScene (8);
	}

	/* Go to Login page */
	public void Login () {
		SceneManager.LoadScene (7);
	}
}

