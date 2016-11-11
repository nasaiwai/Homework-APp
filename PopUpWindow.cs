/**
 * author: Nasa Iwai
 * date: November 5th, 2016
 */
 
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUpWindow : MonoBehaviour {

	public GameObject window;
	public Text messageField;

	// Show (string)
	// Displays the indicated message in a pop-up menu
	public void Open (string message) {
		messageField.text = message;
		window.SetActive (true);
	}

	// Hide()
	// Closes the pop-up window
	public void Close() {
		window.SetActive (false);
	}
}

