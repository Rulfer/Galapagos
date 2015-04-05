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
	public static void hireOne(){
		Debug.Log ("hire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela += 1;
			Stella_kode.oppryddereIsabela += 1;
			Debug.Log ("hire isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina += 1;
			Stella_kode.oppryddereFernandina += 1;
			Debug.Log ("hire fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal += 1;
			Stella_kode.oppryddereSanCristobal += 1;
			Debug.Log ("hire san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador += 1;
			Stella_kode.oppryddereSanSalvador += 1;
			Debug.Log ("hire san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz += 1;
			Stella_kode.oppryddereSantaCruz += 1;
			Debug.Log ("hire santa cruz");
		} 
		else if (oceanInfo.visitedOcean == true) {
			oceanInfo.a_endretOcean += 1;
			Stella_kode.Politi += 1;
			Debug.Log ("hire ocean");
		}
		Stella_kode.okonomi-= 350;
	}

	public static void hireFive(){
		Debug.Log ("hire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela += 5;
			Stella_kode.oppryddereIsabela += 5;
			Debug.Log ("hire isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina += 5;
			Stella_kode.oppryddereFernandina += 5;
			Debug.Log ("hire fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal += 5;
			Stella_kode.oppryddereSanCristobal += 5;
			Debug.Log ("hire san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador += 5;
			Stella_kode.oppryddereSanSalvador += 5;
			Debug.Log ("hire san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz += 5;
			Stella_kode.oppryddereSantaCruz += 5;
			Debug.Log ("hire santa cruz");
		} 
		else if (oceanInfo.visitedOcean == true) {
			oceanInfo.a_endretOcean += 5;
			Stella_kode.Politi += 5;
			Debug.Log ("hire ocean");
		}
		Stella_kode.okonomi-= 1750;
	}

	public static void hireTen(){
		Debug.Log ("hire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela += 10;
			Stella_kode.oppryddereIsabela += 10;
			Debug.Log ("hire isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina += 10;
			Stella_kode.oppryddereFernandina += 10;
			Debug.Log ("hire fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal += 10;
			Stella_kode.oppryddereSanCristobal += 10;
			Debug.Log ("hire san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador += 10;
			Stella_kode.oppryddereSanSalvador += 10;
			Debug.Log ("hire san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz += 10;
			Stella_kode.oppryddereSantaCruz += 10;
			Debug.Log ("hire santa cruz");
		} 
		else if (oceanInfo.visitedOcean == true) {
			oceanInfo.a_endretOcean += 10;
			Stella_kode.Politi += 10;
			Debug.Log ("hire ocean");
		}
		Stella_kode.okonomi-= 3500;
	}
}
