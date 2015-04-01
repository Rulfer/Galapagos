using UnityEngine;
using System.Collections;

public class islandInfo : MonoBehaviour {
	//Variabler som sier hvor mange ansatte som er på hver øy
	public static int ansatteFernadina;
	public static int ansatteIsabela;
	public static int ansatteSanCristobal;
	public static int ansatteSantaCruz;
	public static int ansatteSanSalvador;

	//Denne variabelen oppdateres dersom det sparkes eller ansettes nye folk
	public static int a_endretFernadina;
	public static int a_endretIsabela;
	public static int a_endretSanCristobal;
	public static int a_endretSantaCruz;
	public static int a_endretSanSalvador;

	//Brukes for å si hvilken informasjon til hvilken øy spilleren er ute etter
	public static bool visitedFernadina;
	public static bool visitedIsabela;
	public static bool visitedSanCristobal;
	public static bool visitedSantaCruz;
	public static bool visitedSanSalvador;

	// Use this for initialization
	public static void Start () {
		//Random tall jeg har lagt til
		ansatteFernadina = 20;
		ansatteIsabela = 20;
		ansatteSanCristobal = 20;
		ansatteSanSalvador = 20;
		ansatteSantaCruz = 20;

		//Sørger for at endret er lik antall ansatte i starten
		//Gjøres ikke dette vil masse fine buggy ting skje
		a_endretFernadina = ansatteFernadina;
		a_endretIsabela = ansatteIsabela;
		a_endretSanCristobal = ansatteSanCristobal;
		a_endretSanSalvador = ansatteSanSalvador;
		a_endretSantaCruz = ansatteSantaCruz;

		//Sier at spilleren ikke har besøkt noen plass for å forhindre bugs
		visitedFernadina = false;
		visitedIsabela = false;
		visitedSanCristobal = false;
		visitedSantaCruz = false;
		visitedSanSalvador = false;
	}
	
	// Update is called once per frame
	//Tester om a_endret er ulik ansatte enten i positiv eller negativ retning.
	//Stemmer dette vil antall ansatte oppdateres til å bli lik a_endret,
	//og de nye tallene printes ut via mouseClicker sin showText() funksjon
	void Update () {
		if (a_endretFernadina < ansatteFernadina || a_endretFernadina > ansatteFernadina) {
			ansatteFernadina = a_endretFernadina;
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(0);
		}
		else if (a_endretIsabela < ansatteIsabela || a_endretIsabela > ansatteIsabela) {
			ansatteIsabela = a_endretIsabela;
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(1);
		}
		else if (a_endretSanCristobal < ansatteSanCristobal || a_endretSanCristobal > ansatteSanCristobal) {
			ansatteSanCristobal = a_endretSanCristobal;
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(2);
		}
		else if (a_endretSantaCruz < ansatteSantaCruz || a_endretSantaCruz > ansatteSantaCruz) {
			ansatteSantaCruz = a_endretSantaCruz;
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(3);
		}
		else if (a_endretSanSalvador < ansatteSanSalvador || a_endretSanSalvador > ansatteSanSalvador) {
			ansatteSanSalvador = a_endretSanSalvador;
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(4);
		}
	}
}