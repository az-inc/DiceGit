using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RandomString : MonoBehaviour {
	int str;
	string n;
	Text gg;

	// Use this for initialization
	void Start () {
		str = Random.Range(1, 23);
		gg = GetComponent <Text> ();
		if (str == 1)
			n = "Dont Touch me there :o";
		if (str == 2)
			n = "REROLL THIS SKRUB";
		if (str == 3)
			n = "Thx Arix";
		if (str == 4)
			n = "Joseph is a skrub lord";
		if (str == 5)
			n = "I dont even";
		if (str == 6)
			n = "Plz watch fate zero";
		if (str == 7)
			n = "Girls wearing suits are supah smexy";
		if (str == 8)
			n = "JAY JAY THE MOTHER@#$%ING JET PRANE";
		if (str == 9)
			n = "GG MOE IS STUPID";
		if (str == 10)
			n = "YOU ARE a nice person";
		if (str == 11)
			n = "My cheesecake anus is green";
		if (str == 12)
			n = "Maxed out creditcard";
		if (str == 13)
			n = "Why is this a game";
		if (str == 14)
			n = "GG NO RE";
		if (str == 15)
			n = "usdhr98723h0b";
		if (str == 16)
			n = "Illuminati Confirmed";
		if (str == 17)
			n = "Dont look up 'Baned In Equestria' You will regret it";
		if (str == 18)
			n = "Wow";
		if (str == 19)
			n = "I am a computer program :3";
		if (str == 20)
			n = "Help Im trapped in here";
		if (str == 21)
			n = "Where is the exit?";
		if (str == 22)
			n = "I wish replays were enabled GOD DAMNIT, FUCKKKK, NOOOOOOOOO - Carson 2015";
	}
	
	// Update is called once per frame
	void Update () {

		gg.text = n; 

	}
}
