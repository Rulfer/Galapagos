using UnityEngine;
using System.Collections;

public class fireOpprydder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Tester hvilken øy spilleren besøker. Den korrekte øya vil ha visited = true
	//Endrer a_endret variabelen for korrekt øy og fjerner 5 ansatte.
	//Når disse er endret vil update funksjonen i islandInfo oppdage det og endre verdiene og samtidig oppdatere informasjonen på skjermen
	public static void fireStuff(){
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela -= 5;
			Stella_kode.oppryddereIsabela -= 5;
			Debug.Log ("hire isabela");
		} else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina -= 5;
			Stella_kode.oppryddereFernandina -= 5;
			Debug.Log ("hire fernadina");
		} else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal -= 5;
			Stella_kode.oppryddereSanCristobal -= 5;
			Debug.Log ("hire san cristobal");
		} else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador -= 5;
			Stella_kode.oppryddereSanSalvador -= 5;
			Debug.Log ("hire san salvador");
		} else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz -= 5;
			Stella_kode.oppryddereSantaCruz -= 5;
			Debug.Log ("hire santa cruz");
		}
	}
}
