﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	public void StartGame(){
		SceneManager.LoadScene (1);
		//Application.LoadLevel (1);
	}

	public void EndGame(){
		Debug.Log ("afsf");
		Application.Quit ();
	}
}
