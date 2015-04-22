using UnityEngine;
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
	}

	public static void pauseMoney(){
		isPaused = true;
//		GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (6);
	}

	public static void unPause(){
		isPaused = false;
	}
}
