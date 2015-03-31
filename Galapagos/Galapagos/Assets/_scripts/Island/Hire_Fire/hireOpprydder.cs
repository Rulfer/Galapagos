using UnityEngine;
using System.Collections;

public class hireOpprydder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Tester hvilken øy spilleren besøker. Den korrekte øya vil ha visited = true
	//Endrer a_endret variabelen for korrekt øy og legger til 5 ansatte.
	//Når disse er endret vil update funksjonen i islandInfo oppdage det og endre verdiene og samtidig oppdatere informasjonen på skjermen
	public static void hireStuff(){
		Debug.Log ("hire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela += 5;
			Debug.Log ("hire isabela");
		} else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina += 5;
			Debug.Log ("hire fernadina");
		} else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal += 5;
			Debug.Log ("hire san cristobal");
		} else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador += 5;
			Debug.Log ("hire san salvador");
		} else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz += 5;
			Debug.Log ("hire santa cruz");
		}
	}
}
