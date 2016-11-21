/**
 * author: Nasa Iwai
 * date: November 5th, 2016
 */
 
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUpWindow : MonoBehaviour {

	//public GameObject window;
	public GameObject Profile;
	public GameObject Ranking;
	public GameObject PointForm;
	public GameObject sideMenu;
	private bool sidemenu = true;

	/* Displays the indicated message in a pop-up menu */
	public void Open (string button) {
		if (button.Equals ("profile")) {
			Profile.SetActive (true);
		} else if (button.Equals ("ranking")) {
			Ranking.SetActive (true);
		} else if (button.Equals ("pointform")) {
			PointForm.SetActive (true);
		}
	}

	/* Closes the pop-up window */
	public void Close(string button) {
		//window.SetActive (false);
		if (button.Equals ("profile")) {
			Profile.SetActive (false);
		} else if (button.Equals ("ranking")) {
			Ranking.SetActive (false);
		} else if (button.Equals ("pointform")) {
			if (pointForm.password_check == true)
				PointForm.SetActive (false);
		} else if (button.Equals ("pointclose")) {
			PointForm.SetActive (false);
		}
	}

	/* Open and close the side menu at the left corner */
	public void SideMenu () {
		sideMenu.SetActive (sidemenu);
		sidemenu = !sidemenu;
	}
}

