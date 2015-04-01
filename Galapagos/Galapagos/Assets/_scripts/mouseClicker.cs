using UnityEngine;
using System.Collections;

public class mouseClicker : MonoBehaviour {
	string[] areaName = new string[6];
	public GameObject infoBox;
	public GUIText info;
	public static bool visitedIsabela = false;

	// Use this for initialization
	void Start () {
		areaName[0] = "Fernadina";
		areaName [1] = "Isabela";
		areaName [2] = "San Cristobal";
		areaName [3] = "Santa Cruz";
		areaName [4] = "San Salvador";
		areaName [5] = "Ocean";

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
				showText(0);
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandIsabela") {
				Debug.Log ("treffer Isabela");
				islandInfo.visitedIsabela = true;
				showText(1);
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanCristobal") {
				Debug.Log ("treffer San Cristobal");
				islandInfo.visitedSanCristobal =  true;
				showText(2);
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSantaCruz") {
				Debug.Log ("treffer Santa Cruz");
				islandInfo.visitedSantaCruz = true;
				showText(3);
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanSalvador") {
				Debug.Log ("treffer San Salvador");
				islandInfo.visitedSanSalvador = true;
				showText(4);
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ocean") {
				Debug.Log ("treffer Havet");
				oceanInfo.visitedOcean = true;
				showText(5);
			}

			//Tester om spilleren klikker på enten kjøp eller selg ansatte
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansett") {
				hireOpprydder.hireStuff();
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "spark") {
				fireOpprydder.fireStuff();
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
		info.text += "Antall turister: " + "\n";
		info.text += "Antall dyr: " + "\n";
		info.text += "Mengde søppel: " + "\n";
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
		info.text += "\n";
		info.text += "Ansett/Spark ansatte: ANSETT SPARK";
	}

	void close(){
		infoBox.transform.position = new Vector3 (0, 0, 10);
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