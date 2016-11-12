/*
 * author: Nasa Iwai
 * date: November 11th, 2016
 */

using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Text.RegularExpressions;

public class Profile : MonoBehaviour {

	/* To get data from database and display */
	public Text firstName;
	public Text grade;
	public Text stageLevel;
	public Text points;
	public Text streakLevel;

	/* To change the color of the text based on the gender */
	public Text currentLevel;
	public Text currentPoints;
	public Text streakText;
	public Text streakLevelText;

	public Image streak1, streak2, streak3, streak4;
	public Image background;
	public Image profilePic;

	public int streak;
	public string gender;
	public string profile_pic;
	public int user;
	public string test = "cow";

	public string[] items;

	IEnumerator Start() {
		WWW data = new WWW("http://tclchomeworkapp.000webhostapp.com/loadData.php");
		yield return data;
		string dataString = data.text;	
		items = dataString.Split (';');
		user = 0;

		print (getDataValue(items[user], "firstName:"));
		print (getDataValue (items [user], "reading:"));
		print ("user: " + user);

		firstName.text = getDataValue (items[user], "firstName:");
		stageLevel.text = getDataValue (items [user], "stageLevel:");
		points.text = getDataValue (items [user], "point:");
		grade.text = getDataValue (items[user], "grade:");

		profile_pic = getDataValue (items[user], "profileImage:");
		setProfilePic ();
		print (profile_pic);

		streak = Int32.Parse (getDataValue (items[user], "streak:"));
		streakLevel.text = (streak / 10).ToString();
		setStreak ();

		gender = getDataValue (items [user], "gender:");
		print (getDataValue (items [user], "gender:"));
		print (string.Equals (gender, "girl"));
		setBackground ();
	}

	/*
	 * data = "username:nasaiwai|password:password|firstName:Nasa|lastName:Iwai|
	 * 		   grade:3rd Grade|gender:female|stageLevel:1|point:0|streak:0|
	 * 		   todayStatus:NULL|profileImage:NULL;"
	 * index = "firstName:"
	 */

	string getDataValue(string data, string index) {
		string value = data.Substring (data.IndexOf (index) + index.Length);
		if (value.Contains("|"))
			value = value.Remove (value.IndexOf("|"));
		return value;
	}

	void setProfilePic () {
		profilePic.sprite = Resources.Load<Sprite> (profile_pic) as Sprite;
	}

	void setBackground (){
		if (string.Equals (gender, "girl")) {
			background.sprite = Resources.Load<Sprite> ("girl_background") as Sprite;
		}
		else if (string.Equals (gender, "boy")) {
			background.sprite = Resources.Load<Sprite> ("boy_background") as Sprite;
			//currentLevel.color = new Color(0.0f, 0.56f, 0.31f);
			//currentPoints.color = new Color(0.46f, 1.57f, 0.06f);
			firstName.color = Color.black;
			streakText.color = Color.black;
			currentLevel.color = Color.black;
			currentPoints.color = Color.black;
			streakLevelText.color = Color.black;
		}
	}

	void setStreak () {
		switch (streak % 4) {
		case 0:
			setStreakHelper (false, false, false, false);
			break;
		case 1:
			setStreakHelper (true, false, false, false);
			break;
		case 2:
			setStreakHelper (true, true, false, false);
			break;
		case 3:
			setStreakHelper (true, true, true, false);
			break;
		}

	}

	void setStreakHelper (bool st1, bool st2, bool st3, bool st4) {
		if (st1 == true) {
			streak1.sprite = Resources.Load<Sprite> ("done") as Sprite;
		} else {
			streak1.sprite = Resources.Load<Sprite> ("not_done") as Sprite;
		}

		if (st2 == true) {
			streak2.sprite = Resources.Load<Sprite> ("done") as Sprite;
		} else {
			streak2.sprite = Resources.Load<Sprite> ("not_done") as Sprite;
		}

		if (st3 == true) {
			streak3.sprite = Resources.Load<Sprite> ("done") as Sprite;
		} else {
			streak3.sprite = Resources.Load<Sprite> ("not_done") as Sprite;
		}

		if (st4 == true) {
			streak4.sprite = Resources.Load<Sprite> ("done") as Sprite;
		} else {
			streak4.sprite = Resources.Load<Sprite> ("not_done") as Sprite;
		}
	}

}
