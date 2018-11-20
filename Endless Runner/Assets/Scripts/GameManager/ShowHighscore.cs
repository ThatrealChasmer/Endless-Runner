using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighscore : MonoBehaviour {

	public Text highscoreText;
	// Update is called once per frame
	void Start () {
        highscoreText.text = Static.highscore.ToString();
	}
}
