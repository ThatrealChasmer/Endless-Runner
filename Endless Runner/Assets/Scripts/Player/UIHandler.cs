﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour {

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


}
