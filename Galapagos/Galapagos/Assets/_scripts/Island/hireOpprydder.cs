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
		if (Stella_kode.okonomi >= 350) {
			if (islandInfo.visitedIsabela == true) {
				islandInfo.a_endretIsabela += 1;
				Stella_kode.oppryddereIsabela += 1;
			} else if (islandInfo.visitedFernadina == true) {
				islandInfo.a_endretFernadina += 1;
				Stella_kode.oppryddereFernandina += 1;
			} else if (islandInfo.visitedSanCristobal == true) {
				islandInfo.a_endretSanCristobal += 1;
				Stella_kode.oppryddereSanCristobal += 1;
			} else if (islandInfo.visitedSanSalvador == true) {
				islandInfo.a_endretSanSalvador += 1;
				Stella_kode.oppryddereSanSalvador += 1;
			} else if (islandInfo.visitedSantaCruz == true) {
				islandInfo.a_endretSantaCruz += 1;
				Stella_kode.oppryddereSantaCruz += 1;
			} else if (oceanInfo.visitedOcean == true) {
				oceanInfo.a_endretOcean += 1;
				Stella_kode.Politi += 1;
			}
			Stella_kode.okonomi -= 350;
		}
	}

	public static void hireFive(){
		if (Stella_kode.okonomi >= 1750) {
			if (islandInfo.visitedIsabela == true) {
				islandInfo.a_endretIsabela += 5;
				Stella_kode.oppryddereIsabela += 5;
			} else if (islandInfo.visitedFernadina == true) {
				islandInfo.a_endretFernadina += 5;
				Stella_kode.oppryddereFernandina += 5;
			} else if (islandInfo.visitedSanCristobal == true) {
				islandInfo.a_endretSanCristobal += 5;
				Stella_kode.oppryddereSanCristobal += 5;
			} else if (islandInfo.visitedSanSalvador == true) {
				islandInfo.a_endretSanSalvador += 5;
				Stella_kode.oppryddereSanSalvador += 5;
			} else if (islandInfo.visitedSantaCruz == true) {
				islandInfo.a_endretSantaCruz += 5;
				Stella_kode.oppryddereSantaCruz += 5;
			} else if (oceanInfo.visitedOcean == true) {
				oceanInfo.a_endretOcean += 5;
				Stella_kode.Politi += 5;
			}
			Stella_kode.okonomi -= 1750;
		}
	}

	public static void hireTen(){
		if (Stella_kode.okonomi >= 3500) {
			if (islandInfo.visitedIsabela == true) {
				islandInfo.a_endretIsabela += 10;
				Stella_kode.oppryddereIsabela += 10;
			} else if (islandInfo.visitedFernadina == true) {
				islandInfo.a_endretFernadina += 10;
				Stella_kode.oppryddereFernandina += 10;
			} else if (islandInfo.visitedSanCristobal == true) {
				islandInfo.a_endretSanCristobal += 10;
				Stella_kode.oppryddereSanCristobal += 10;
			} else if (islandInfo.visitedSanSalvador == true) {
				islandInfo.a_endretSanSalvador += 10;
				Stella_kode.oppryddereSanSalvador += 10;
			} else if (islandInfo.visitedSantaCruz == true) {
				islandInfo.a_endretSantaCruz += 10;
				Stella_kode.oppryddereSantaCruz += 10;
			} else if (oceanInfo.visitedOcean == true) {
				oceanInfo.a_endretOcean += 10;
				Stella_kode.Politi += 10;
			}
			Stella_kode.okonomi -= 3500;
		}
	}
}
