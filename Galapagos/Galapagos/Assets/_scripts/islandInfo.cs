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

	//Holder på antall turister på øyene
	public static int turisterFernandina;
	public static int turisterIsabela;
	public static int turisterSanCristobal;
	public static int turisterSanSalvador;
	public static int turisterSantaCruz;

	//Holder på hvor stor populasjonen på hver enkelt øy er
	public static int populasjonFernandina;
	public static int populasjonIsabela;
	public static int populasjonSanCristobal;
	public static int populasjonSanSalvador;
	public static int populasjonSantaCruz;

	//Brukes for å si hvilken informasjon til hvilken øy spilleren er ute etter
	public static bool visitedFernadina;
	public static bool visitedIsabela;
	public static bool visitedSanCristobal;
	public static bool visitedSantaCruz;
	public static bool visitedSanSalvador;

	// Use this for initialization
	public static void Start () {
		//Random tall jeg har lagt til
		ansatteFernadina = 1200;
		ansatteIsabela = 1200;
		ansatteSanCristobal = 1200;
		ansatteSanSalvador = 1200;
		ansatteSantaCruz = 1200;

		//Sørger for at endret er lik antall ansatte i starten
		//Gjøres ikke dette vil masse fine buggy ting skje
		a_endretFernadina = ansatteFernadina;
		a_endretIsabela = ansatteIsabela;
		a_endretSanCristobal = ansatteSanCristobal;
		a_endretSanSalvador = ansatteSanSalvador;
		a_endretSantaCruz = ansatteSantaCruz;

		turisterFernandina = Stella_kode.turisterFernandina;
		turisterIsabela = Stella_kode.turisterIsabela;
		turisterSanCristobal = Stella_kode.turisterSanCristobal;
		turisterSanSalvador = Stella_kode.turisterSanSalvador;
		turisterSantaCruz = Stella_kode.turisterSantaCruz;

		populasjonFernandina = Stella_kode.populasjonFernandina;
		populasjonIsabela = Stella_kode.populasjonIsabela;
		populasjonSanCristobal = Stella_kode.populasjonSanCristobal;
		populasjonSanSalvador = Stella_kode.populasjonSanSalvador;
		populasjonSantaCruz = Stella_kode.populasjonSantaCruz;

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

		if(visitedFernadina == true){
			if (turisterFernandina < Stella_kode.turisterFernandina || turisterFernandina > Stella_kode.turisterFernandina) {
				turisterFernandina = Stella_kode.turisterFernandina;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(0);
			}
			else if (populasjonFernandina < Stella_kode.populasjonFernandina || populasjonFernandina > Stella_kode.populasjonFernandina) {
			populasjonFernandina = Stella_kode.populasjonFernandina;
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(0);
			}
		}
		else if(visitedIsabela == true){
			if (turisterIsabela < Stella_kode.turisterIsabela || turisterIsabela > Stella_kode.turisterIsabela) {
				turisterIsabela = Stella_kode.turisterIsabela;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(1);
			}
			else if (populasjonIsabela < Stella_kode.populasjonIsabela || populasjonIsabela > Stella_kode.populasjonIsabela) {
				populasjonIsabela = Stella_kode.populasjonIsabela;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(1);
			}
		}
		else if(visitedSanCristobal == true){
			if (turisterSanCristobal < Stella_kode.turisterSanCristobal || turisterSanCristobal > Stella_kode.turisterSanCristobal) {
				turisterSanCristobal = Stella_kode.turisterSanCristobal;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(2);
			}
			else if (populasjonSanCristobal < Stella_kode.populasjonSanCristobal || populasjonSanCristobal > Stella_kode.populasjonSanCristobal) {
				populasjonSanCristobal = Stella_kode.populasjonSanCristobal;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(2);
			}
		}
		else if(visitedSanSalvador == true){
			if (turisterSanSalvador < Stella_kode.turisterSanSalvador || turisterSanSalvador > Stella_kode.turisterSanSalvador) {
				turisterSanSalvador = Stella_kode.turisterSanSalvador;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(3);
			}
			else if (populasjonSanSalvador < Stella_kode.populasjonSanSalvador || populasjonSanSalvador > Stella_kode.populasjonSanSalvador) {
				populasjonSanSalvador = Stella_kode.populasjonSanSalvador;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(3);
			}
		}
		else if (visitedSantaCruz == true){
			if (turisterSantaCruz < Stella_kode.turisterSantaCruz || turisterSantaCruz > Stella_kode.turisterSantaCruz) {
				turisterSantaCruz = Stella_kode.turisterSantaCruz;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(4);
			}
			else if (populasjonSantaCruz < Stella_kode.populasjonSantaCruz || populasjonSantaCruz > Stella_kode.populasjonSantaCruz) {
				populasjonSantaCruz = Stella_kode.populasjonSantaCruz;
				GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(4);
			}
		}
	}
}