using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    public int score = 0;
    public Text scoreText;

	// Use this for initialization
	public void Play()
    {
        SceneManager.LoadScene(1);
    }
	// Update is called once per frame
	public void Quit()
    {
        Application.Quit();
    }

    public void SetScore()
    {
        scoreText.text = score.ToString();
    }

    public void Death()
    {
        Static.score = score;
        if(Static.highscore < score)
        {
            Static.highscore = score;
        }
        PlayerPrefs.SetInt("Highscore", Static.highscore);
        SceneManager.LoadScene(2);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        SetScore();
    }
}
