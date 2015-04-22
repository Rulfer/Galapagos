using UnityEngine;
using System.Collections;

public class shortcuts : MonoBehaviour {

	//Snarveier i spillet som kan nås ved hjelp av tastetrykk.
	//Tallene 1-5 åpner øyene sine informasjonskort, 
	//esc paused/unpauser spillet
	void Update () {
		if(pause.isPaused == false){
			if (Input.GetKeyDown ("1")) {
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
				islandInfo.visitedFernadina = true;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (0);
			} else if (Input.GetKeyDown ("2")) {
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
				islandInfo.visitedIsabela = true;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (1);
			} else if (Input.GetKeyDown ("3")) {
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
				islandInfo.visitedSanCristobal = true;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (2);
			} else if (Input.GetKeyDown ("4")) {
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
				islandInfo.visitedSanSalvador = true;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (3);
			} else if (Input.GetKeyDown ("5")) {
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
				islandInfo.visitedSantaCruz = true;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (4);
			} 
		}

		//Dersom spillet ikke er over kan esc klikkes
		//Denne pauser / un-pauser spillet
		if (winLoose.endGame == false) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				Debug.Log ("Hello?");
				if (pause.isPaused == false) { //Dersom spillet er kjørende skal det pauses
					pause.pauseGame ();
					GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (6);
				} else if (pause.isPaused == true) {//Dersom spillet er pauset skal det un-pauses
					pause.unPause ();
					GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
				}
			}
		}
	}
}
