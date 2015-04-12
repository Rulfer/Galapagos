﻿using UnityEngine;
using System.Collections;

public class mouseClicker : MonoBehaviour {
	string[] areaName = new string[6];
	public GameObject infoBox;
	public GameObject shopBox;
	public GUIText shop;
	public GUIText info;
	public static bool visitedIsabela = false;
	bool visitedShop;

	// Use this for initialization
	void Start () {
		areaName[0] = "Fernandina";
		areaName [1] = "Isabela";
		areaName [2] = "San Cristobal";
		areaName [3] = "Santa Cruz";
		areaName [4] = "San Salvador";
		areaName [5] = "Ocean";

		visitedShop = false;

		islandInfo.Start (); //Startvariablene til islandInfo lagres nå
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) { //Tester om spilleren klikker med musa

			//Spilleren klikker med musa,og vi ser om en av øyene klikkes på.
			//Gjløres dette vil vi sette bool visitedX = true for korrekt øy
			//Printer så ut informasjonen til øya i showText();
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandFernadina") {
				Debug.Log ("treffer Fernadina");
				islandInfo.visitedFernadina = true;
				showText (0);
			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandIsabela") {
				Debug.Log ("treffer Isabela");
				islandInfo.visitedIsabela = true;
				showText (1);
			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanCristobal") {
				Debug.Log ("treffer San Cristobal");
				islandInfo.visitedSanCristobal = true;
				showText (2);
			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSantaCruz") {
				Debug.Log ("treffer Santa Cruz");
				islandInfo.visitedSantaCruz = true;
				showText (3);
			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanSalvador") {
				Debug.Log ("treffer San Salvador");
				islandInfo.visitedSanSalvador = true;
				showText (4);
			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ocean") {
				Debug.Log ("treffer Havet");
				oceanInfo.visitedOcean = true;
				showText (5);

			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "shop") {
				if(visitedShop == false){
					showShop();
					Debug.Log ("asdasdadasdas");
				}
			} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "closeShop"){
				if(visitedShop == true){
					shopBox.transform.position = new Vector3 (0, 0, 10);
					shop.text = "";
					visitedShop = false;
				}
			}

			//Tester om spilleren klikker på enten kjøp eller selg ansatte
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettOne") {
				hireOpprydder.hireOne();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettFive") {
				hireOpprydder.hireFive();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettTen") {
				hireOpprydder.hireTen();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkOne") {
				fireOpprydder.fireOne();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkFive") {
				fireOpprydder.fireFive();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkTen") {
				fireOpprydder.fireTen();
			}

			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "buildHotel") {
				Hotel.build();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "destroyHotel") {
				Hotel.destroy();
			}

			//Tester om spilleren klikker utenfor informasjonsboksen (er en hitbox der)
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "close") {
				Debug.Log ("lukker");
				close ();
			}
		}

	}

	public void showText(int n){
		infoBox.transform.position = new Vector3 (0, 0, 0);
		
		info.text = "";
		info.text = areaName [n] + "\n";
		info.text += "\n";
		switch (n) {
		case 0: info.text += "Populasjon: " + islandInfo.populasjonFernandina;
			break;
		case 1: info.text += "Populasjon: " + islandInfo.populasjonIsabela;
			break;
		case 2: info.text += "Populasjon: " + islandInfo.populasjonSanCristobal;
			break;
		case 3: info.text += "Populasjon: " + islandInfo.populasjonSanSalvador;
			break;
		case 4: info.text += "Populasjon: " + islandInfo.populasjonSantaCruz;
			break;
		case 5: info.text += "Populasjon: Dette er et hav.";
			break;
		}
		info.text += "\n";
		switch (n) {
		case 0: info.text += "Antall turister: " + islandInfo.turisterFernandina;
			break;
		case 1: info.text += "Antall turister: " + islandInfo.turisterIsabela;
			break;
		case 2: info.text += "Antall turister: " + islandInfo.turisterSanCristobal;
			break;
		case 3: info.text += "Antall turister: " + islandInfo.turisterSanSalvador;
			break;
		case 4: info.text += "Antall turister: " + islandInfo.turisterSantaCruz;
			break;
		case 5: info.text += "Antall turister: Dette er et hav.";
			break;
		}
		info.text += "\n";
		switch (n) {
		case 0: info.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngFernandina + Stella_kode.Iguana_FertilFernandina) + "\n";
			info.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilFernandina + Stella_kode.Brown_Pelican_FertilFernandina) + "\n"; 
			break;
		case 1: info.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngIsabela + Stella_kode.Iguana_FertilIsabela) + "\n";
			info.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilIsabela + Stella_kode.Brown_Pelican_FertilIsabela) + "\n"; 
			break;
		case 2: info.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngSanCristobal + Stella_kode.Iguana_FertilSanCristobal) + "\n";
			info.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilSanCristobal + Stella_kode.Brown_Pelican_FertilSanCristobal) + "\n"; 
			break;
		case 3: info.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngSanSalvador + Stella_kode.Iguana_FertilSanSalvador) + "\n";
			info.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilSanSalvador + Stella_kode.Brown_Pelican_FertilSanSalvador) + "\n"; 
			break;
		case 4: info.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngSantaCruz + Stella_kode.Iguana_FertilSantaCruz) + "\n";
			info.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilSantaCruz + Stella_kode.Brown_Pelican_FertilSantaCruz) + "\n"; 
			break;
		}

		switch (n) {
		case 0: info.text += "Mengde søppel: " + islandInfo.forsoplingFernandina;
			break;
		case 1: info.text += "Mengde søppel: " + islandInfo.forsoplingIsabela;
			break;
		case 2: info.text += "Mengde søppel: " + islandInfo.forsoplingSanCristobal;
			break;
		case 3: info.text += "Mengde søppel: " + islandInfo.forsoplingSanSalvador;
			break;
		case 4: info.text += "Mengde søppel: " + islandInfo.forsoplingSantaCruz;
			break;
		case 5: info.text += "Mengde søppel: 0";
			break;
		}
		info.text += "\n";
		info.text += "\n";
		switch (n) {
		case 0: info.text += "Antall oppryddere: " + islandInfo.ansatteFernadina;
			break;
		case 1: info.text += "Antall oppryddere: " + islandInfo.ansatteIsabela;
			break;
		case 2: info.text += "Antall oppryddere: " + islandInfo.ansatteSanCristobal;
			break;
		case 3: info.text += "Antall oppryddere: " + islandInfo.ansatteSantaCruz;
			break;
		case 4: info.text += "Antall oppryddere: " + islandInfo.ansatteSanSalvador;
			break;
		case 5: info.text += "Antall politifolk: " + oceanInfo.ansatteOcean;
			break;
		}
		info.text += "\n";
		info.text += "\n";
		info.text += "Ansett/Spark ansatte: ANSETT SPARK";
	}

	void showShop() {
		visitedShop = true;
		shopBox.transform.position = new Vector3 (4.35f, 0.4825f, 0f);
		shop.text += "\n";
		shop.text += "+1 opprydder      -1 opprydder";
		shop.text += "\n";
		shop.text += "\n";
		shop.text += "+5 oppryddere     -5 oppryddere";
		shop.text += "\n";
		shop.text += "\n";
		shop.text += "+10 oppryddere    -10 oppryddere";
		shop.text += "\n";
	}

	public void close(){
		infoBox.transform.position = new Vector3 (0, 0, 10);
		shopBox.transform.position = new Vector3 (0, 0, 10);
		shop.text = "";
		visitedShop = false;
		info.text = "";

		if (islandInfo.visitedFernadina == true) {
			islandInfo.visitedFernadina = false;
		}if (islandInfo.visitedIsabela == true) {
			islandInfo.visitedIsabela = false;
		}if (islandInfo.visitedSanCristobal == true) {
			islandInfo.visitedSanCristobal = false;
		}if (islandInfo.visitedSanSalvador == true) {
			islandInfo.visitedSanSalvador = false;
		}if (islandInfo.visitedSantaCruz == true) {
			islandInfo.visitedSantaCruz = false;
		}if (oceanInfo.visitedOcean == true) {
			oceanInfo.visitedOcean = false;
		}
	}
}