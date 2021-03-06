﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	void Start () {
	}
	void Update () {
		//if we press P or esc, we should pause
		if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P)){
			Time.timeScale = 0;
			//assume this script is attached to
			//pause menu canvas
			gameObject.GetComponent<Canvas>().enabled = true;
		}
	}
	public void Resume(){
		Time.timeScale = 1;
		gameObject.GetComponent<Canvas>().enabled = false;
	}
	public void QuitGame(){
		//this will quite the .exe app of 
		//unity when the game is built
		//wont do anything in the editor
		Application.Quit ();
	
	}
    public void PlayGame() {
        SceneManager.LoadScene("Level1Layout");
    }
}
