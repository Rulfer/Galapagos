﻿using UnityEngine;
using System.Collections;

public class fireOpprydder : MonoBehaviour {
	int tempFernandina;
	// Use this for initialization
	void Start () {
		tempFernandina = islandInfo.ansatteFernadina;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Tester hvilken øy spilleren besøker. Den korrekte øya vil ha visited = true
	//Endrer a_endret variabelen for korrekt øy og fjerner 5 ansatte.
	//Når disse er endret vil update funksjonen i islandInfo oppdage det og endre verdiene og samtidig oppdatere informasjonen på skjermen
	public static void fireOne(){
		Debug.Log ("fire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela -= 1;
			Debug.Log ("fire isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina -= 1;
			Debug.Log ("fire fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal -= 1;
			Debug.Log ("fire san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador -= 1;
			Debug.Log ("fire san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz -= 1;
			Debug.Log ("fire santa cruz");
		} 
		else if (oceanInfo.visitedOcean == true) {
			oceanInfo.a_endretOcean -= 1;
			Stella_kode.Politi -= 1;
			Debug.Log ("fire ocean");
		}
	}
	
	public static void fireFive(){
		Debug.Log ("fire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela -= 5;
			Debug.Log ("fire isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina -= 5;
			Debug.Log ("fire fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal -= 5;
			Debug.Log ("fire san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador -= 5;
			Debug.Log ("fire san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz -= 5;
			Debug.Log ("fire santa cruz");
		} 
		else if (oceanInfo.visitedOcean == true) {
			oceanInfo.a_endretOcean -= 5;
			Stella_kode.Politi -= 5;
			Debug.Log ("fire ocean");
		}
	}
	
	public static void fireTen(){
		Debug.Log ("fire stuff");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.a_endretIsabela -= 10;
			Debug.Log ("fire isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.a_endretFernadina -= 10;
			Stella_kode.oppryddereFernandina -= 10;
			Debug.Log ("fire fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.a_endretSanCristobal -= 10;
			Debug.Log ("fire san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.a_endretSanSalvador -= 10;
			Debug.Log ("fire san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.a_endretSantaCruz -= 10;
			Debug.Log ("fire santa cruz");
		} 
		else if (oceanInfo.visitedOcean == true) {
			oceanInfo.a_endretOcean -= 10;
			Stella_kode.Politi -= 10;
			Debug.Log ("fire ocean");
		}
	}
}