/*
 * author: Nasa Iwai
 * date: November 10th, 2016
 */

using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Text.RegularExpressions;

public class Profile : MonoBehaviour {

	public Text firstName;
	public Text grade;
	public Text stageLevel;
	public Text points;
	public Image reading;
	public Image writing;
	public Image math;

	public bool DoneReading;
	public bool DoneWriting;
	public bool DoneMath;

	public string[] items;

	IEnumerator Start() {
		WWW data = new WWW("http://tclchomeworkapp.000webhostapp.com/loadData.php");
		yield return data;
		string dataString = data.text;	
		items = dataString.Split (';');

		print (getDataValue(items[2], "firstName:"));
		print (getDataValue (items [2], "reading:"));

		firstName.text = getDataValue (items[2], "firstName:");
		stageLevel.text = getDataValue (items [2], "stageLevel:");
		points.text = getDataValue (items [2], "point:");
		grade.text = getDataValue (items[2], "grade:");
		DoneReading = Convert.ToBoolean (getDataValue (items [2], "reading:"));
		DoneWriting = Convert.ToBoolean (getDataValue (items [2], "writing:"));
		DoneMath = Convert.ToBoolean (getDataValue (items [2], "math:"));
		setAccomplishment();

		//Console.WriteLine (DoneReading.ToString());
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

	void setAccomplishment () {
		if(DoneReading) {
			reading.sprite = Resources.Load<Sprite> ("settings") as Sprite;
		} else {
			reading.sprite = Resources.Load<Sprite> ("not_done") as Sprite;
		}
	}

}
