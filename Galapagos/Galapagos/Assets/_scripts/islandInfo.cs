﻿using UnityEngine;
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

	public static int nyeTuristerFernandina;
	public static int nyeTuristerIsabela;
	public static int nyeTuristerSanCristobal;
	public static int nyeTuristerSanSalvador;
	public static int nyeTuristerSantaCruz;

	//Holder på hvor stor populasjonen på hver enkelt øy er
	public static int populasjonFernandina;
	public static int populasjonIsabela;
	public static int populasjonSanCristobal;
	public static int populasjonSanSalvador;
	public static int populasjonSantaCruz;

	public static int forsoplingFernandina;
	public static int forsoplingIsabela;
	public static int forsoplingSanCristobal;
	public static int forsoplingSanSalvador;
	public static int forsoplingSantaCruz;

	public static int nyForsoplingFernandina;
	public static int nyForsoplingIsabela;
	public static int nyForsoplingSanCristobal;
	public static int nyForsoplingSanSalvador;
	public static int nyForsoplingSantaCruz;

	//Brukes for å si hvilken informasjon til hvilken øy spilleren er ute etter
	public static bool visitedFernadina;
	public static bool visitedIsabela;
	public static bool visitedSanCristobal;
	public static bool visitedSantaCruz;
	public static bool visitedSanSalvador;

	public static bool fernandinaOppdatert;

	// Use this for initialization
	public static void Start () {
		//Random tall jeg har lagt til
		ansatteFernadina = 5;
		ansatteIsabela = 2;
		ansatteSanCristobal = 4;
		ansatteSanSalvador = 3;
		ansatteSantaCruz = 3;

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

		nyeTuristerFernandina = turisterFernandina;
		nyeTuristerIsabela = turisterIsabela;
		nyeTuristerSanCristobal = turisterSanCristobal;
		nyeTuristerSanSalvador = turisterSanSalvador;
		nyeTuristerSantaCruz = turisterSantaCruz;

		populasjonFernandina = Stella_kode.populasjonFernandina;
		populasjonIsabela = Stella_kode.populasjonIsabela;
		populasjonSanCristobal = Stella_kode.populasjonSanCristobal;
		populasjonSanSalvador = Stella_kode.populasjonSanSalvador;
		populasjonSantaCruz = Stella_kode.populasjonSantaCruz;

		forsoplingFernandina = (turisterFernandina * 15) + (populasjonFernandina * 15);
		forsoplingIsabela = (turisterIsabela * 15) + (populasjonIsabela * 15);
		forsoplingSanCristobal = turisterSanCristobal * 15 + populasjonSanCristobal * 15;
		forsoplingSanSalvador = turisterSanSalvador * 15 + populasjonSanSalvador * 15;
		forsoplingSantaCruz = turisterSantaCruz * 15 + populasjonSantaCruz * 15;

		nyForsoplingFernandina = forsoplingFernandina;
		nyForsoplingIsabela = forsoplingIsabela;
		nyForsoplingSanCristobal = forsoplingSanCristobal;
		nyForsoplingSanSalvador = forsoplingSanSalvador;
		nyForsoplingSantaCruz = forsoplingSantaCruz;

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
			if(a_endretFernadina <= 0){
				ansatteFernadina = 0; 
				a_endretFernadina = ansatteFernadina;
				Stella_kode.oppryddereFernandina = ansatteFernadina;
			}
			else{
				ansatteFernadina = a_endretFernadina;
				Stella_kode.oppryddereFernandina = ansatteFernadina;
			}
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(0);
		}
		else if (a_endretIsabela < ansatteIsabela || a_endretIsabela > ansatteIsabela) {
			if(a_endretIsabela <= 0){
				ansatteIsabela = 0; 
				a_endretIsabela = ansatteIsabela;
				Stella_kode.oppryddereIsabela = ansatteIsabela;
			}
			else{
				ansatteIsabela = a_endretIsabela;
				Stella_kode.oppryddereIsabela = ansatteIsabela;
			}
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(1);
		}
		else if (a_endretSanCristobal < ansatteSanCristobal || a_endretSanCristobal > ansatteSanCristobal) {
			if(a_endretSanCristobal <= 0){
				ansatteSanCristobal = 0; 
				a_endretSanCristobal = ansatteSanCristobal;
				Stella_kode.oppryddereSanCristobal = ansatteSanCristobal;
			}
			else{
				ansatteSanCristobal = a_endretSanCristobal;
				Stella_kode.oppryddereSanCristobal = ansatteSanCristobal;
			}
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(2);
		}
		else if (a_endretSantaCruz < ansatteSantaCruz || a_endretSantaCruz > ansatteSantaCruz) {
			if(a_endretSantaCruz <= 0){
				ansatteSantaCruz = 0; 
				a_endretSantaCruz = ansatteSantaCruz;
				Stella_kode.oppryddereSantaCruz = ansatteSantaCruz;
			}
			else{
				ansatteSantaCruz = a_endretSantaCruz;
				Stella_kode.oppryddereSantaCruz = ansatteSantaCruz;
			}
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(3);
		}
		else if (a_endretSanSalvador < ansatteSanSalvador || a_endretSanSalvador > ansatteSanSalvador) {
			if(a_endretSanSalvador <= 0){
				ansatteSanSalvador = 0; 
				a_endretSanSalvador = ansatteSanSalvador;
				Stella_kode.oppryddereSanSalvador = ansatteSanSalvador;
			}
			else{
				ansatteSanSalvador = a_endretSanSalvador;
				Stella_kode.oppryddereSanSalvador = ansatteSanSalvador;
			}
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(4);
		}

		//Dersom turismen oppdateres skal dette skje her
		if (turisterFernandina < nyeTuristerFernandina || turisterFernandina > nyeTuristerFernandina) {
			turisterFernandina = nyeTuristerFernandina;
		} else if (turisterIsabela < nyeTuristerIsabela || turisterIsabela > nyeTuristerIsabela) {
			turisterIsabela = nyeTuristerIsabela;
		} else if (turisterSanCristobal < nyeTuristerSanCristobal || turisterSanCristobal > nyeTuristerSanCristobal) {
			turisterSanCristobal = nyeTuristerSanCristobal;
		} else if (turisterSanSalvador < nyeTuristerSanSalvador || turisterSanSalvador > nyeTuristerSanSalvador) {
			turisterSanSalvador = nyeTuristerSanSalvador;
		} else if (turisterSantaCruz < nyeTuristerSantaCruz || turisterSantaCruz > nyeTuristerSantaCruz) {
			turisterSantaCruz = nyeTuristerSantaCruz;
		}

		if (populasjonFernandina < Stella_kode.populasjonFernandina || populasjonFernandina > Stella_kode.populasjonFernandina) {
			populasjonFernandina = Stella_kode.populasjonFernandina;
		} else if (populasjonIsabela < Stella_kode.populasjonIsabela || populasjonIsabela > Stella_kode.populasjonIsabela) {
			populasjonIsabela = Stella_kode.populasjonIsabela;
		} else if (populasjonSanCristobal < Stella_kode.populasjonSanCristobal || populasjonSanCristobal > Stella_kode.populasjonSanCristobal) {
			populasjonSanCristobal = Stella_kode.populasjonSanCristobal;
		} else if (populasjonSanSalvador < Stella_kode.populasjonSanSalvador || populasjonSanSalvador > Stella_kode.populasjonSanSalvador) {
			populasjonSanSalvador = Stella_kode.populasjonSanSalvador;
		} else if (populasjonSantaCruz < Stella_kode.populasjonSantaCruz || populasjonSantaCruz > Stella_kode.populasjonSantaCruz) {
			populasjonSantaCruz = Stella_kode.populasjonSantaCruz;
		}

		if (forsoplingFernandina < nyForsoplingFernandina || forsoplingFernandina > nyForsoplingFernandina) {
			forsoplingFernandina = nyForsoplingFernandina;
			Debug.Log ("Forsopling hos fernandina er oppdatert: " + nyForsoplingFernandina);
		} else if (forsoplingIsabela < nyForsoplingIsabela || forsoplingIsabela > nyForsoplingIsabela) {
			forsoplingIsabela = nyForsoplingIsabela;
		} else if (forsoplingSanCristobal < nyForsoplingSanCristobal || forsoplingSanCristobal > nyForsoplingSanCristobal) {
			forsoplingSanCristobal = nyForsoplingSanCristobal;
		} else if (forsoplingSanSalvador < nyForsoplingSanSalvador || forsoplingSanSalvador > nyForsoplingSanSalvador) {
			forsoplingSanSalvador = nyForsoplingSanSalvador;
		} else if (forsoplingSantaCruz < nyForsoplingSantaCruz || forsoplingSantaCruz > nyForsoplingSantaCruz) {
			forsoplingSantaCruz = nyForsoplingSantaCruz;
		}



		if (visitedFernadina == true) {
			if (turisterFernandina < nyeTuristerFernandina || turisterFernandina > nyeTuristerFernandina) {
				turisterFernandina = nyeTuristerFernandina;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (0);
			} else if (populasjonFernandina < Stella_kode.populasjonFernandina || populasjonFernandina > Stella_kode.populasjonFernandina) {
				populasjonFernandina = Stella_kode.populasjonFernandina;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (0);
			} else if (forsoplingFernandina < nyForsoplingFernandina || forsoplingFernandina > nyForsoplingFernandina) {
				forsoplingFernandina = nyForsoplingFernandina;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (0);
			}
		} else if (visitedIsabela == true) {
				if (turisterIsabela < nyeTuristerIsabela || turisterIsabela > nyeTuristerIsabela) {
				turisterIsabela = nyeTuristerIsabela;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (1);
			} else if (populasjonIsabela < Stella_kode.populasjonIsabela || populasjonIsabela > Stella_kode.populasjonIsabela) {
				populasjonIsabela = Stella_kode.populasjonIsabela;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (1);
			} else if (forsoplingIsabela < nyForsoplingIsabela || forsoplingIsabela > nyForsoplingIsabela) {
				forsoplingIsabela = nyForsoplingIsabela;
				Debug.Log("her har søppelet til isabela endra seg");
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (1);
			} 

		} else if (visitedSanCristobal == true) {
			if (turisterSanCristobal < nyeTuristerSanCristobal || turisterSanCristobal > nyeTuristerSanCristobal) {
				turisterSanCristobal = nyeTuristerSanCristobal;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (2);
			} else if (populasjonSanCristobal < Stella_kode.populasjonSanCristobal || populasjonSanCristobal > Stella_kode.populasjonSanCristobal) {
				populasjonSanCristobal = Stella_kode.populasjonSanCristobal;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (2);
			} else if (forsoplingIsabela < nyForsoplingIsabela || forsoplingIsabela > nyForsoplingIsabela) {
				forsoplingIsabela = nyForsoplingIsabela;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (2);
			} 

		} else if (visitedSanSalvador == true) {
			if (turisterSanSalvador < nyeTuristerSanSalvador || turisterSanSalvador > nyeTuristerSanSalvador) {
				turisterSanSalvador = nyeTuristerSanSalvador;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (3);
			} else if (populasjonSanSalvador < Stella_kode.populasjonSanSalvador || populasjonSanSalvador > Stella_kode.populasjonSanSalvador) {
				populasjonSanSalvador = Stella_kode.populasjonSanSalvador;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (3);
			} else if (forsoplingSanSalvador < nyForsoplingSanSalvador || forsoplingSanSalvador > nyForsoplingSanSalvador) {
				forsoplingSanSalvador = nyForsoplingSanSalvador;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (3);
			}
		} else if (visitedSantaCruz == true) {
			if (turisterSantaCruz < nyeTuristerSantaCruz || turisterSantaCruz > nyeTuristerSantaCruz) {
				turisterSantaCruz = nyeTuristerSantaCruz;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (4);
			} else if (populasjonSantaCruz < Stella_kode.populasjonSantaCruz || populasjonSantaCruz > Stella_kode.populasjonSantaCruz) {
				populasjonSantaCruz = Stella_kode.populasjonSantaCruz;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (4);
			} else if (forsoplingSantaCruz < nyForsoplingSantaCruz || forsoplingSantaCruz > nyForsoplingSantaCruz) {
				forsoplingSantaCruz = nyForsoplingSantaCruz;
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (3);
			}
		}
	}
}