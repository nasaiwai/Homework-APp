/**
 * author: Nasa Iwai
 * date: November 5th, 2016
 */
 
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUpWindow : MonoBehaviour {

	public GameObject window;

	/* Displays the indicated message in a pop-up menu */
	public void Open () {
		window.SetActive (true);
	}

	/* Closes the pop-up window */
	public void Close() {
		window.SetActive (false);
	}
}

