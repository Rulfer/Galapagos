﻿using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	public static bool isPaused = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void pauseGame(){
		isPaused = true;
		GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().pausedText ();
	}

	public static void unPause(){
		isPaused = false;
	}
}
