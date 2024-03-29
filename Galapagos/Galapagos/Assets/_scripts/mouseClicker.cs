﻿using UnityEngine;
using System.Collections;

public class mouseClicker : MonoBehaviour {
	public GameObject infoBoxIsabela;
	public GameObject infoBoxCristobal;
	public GameObject infoBoxSalvador;
	public GameObject infoBoxCruz;
	public GameObject infoBoxFernadina;
	public GameObject infoBoxHav;
	public GameObject shopBox;
	public GameObject upgradeBox;
	public GameObject adminBox;
	public GameObject pauseBox;
	public GameObject endscreenBox;
	public GameObject economyBox;

//	public GameObject weeklybox;
//	public GameObject pausedBox;
	public GUIText shop;
	public GUIText infoIsabela;	
	public GUIText infoCristobal;
	public GUIText infoSalvador;
	public GUIText infoCruz;
	public GUIText infoFernadina;
	public GUIText infoHav;
	public GUIText infoAdmin;
	public GUIText infoPause;
	public GUIText infoEconomy;
	public GUIText infoEconomy1;
	public GUIText infoEconomy2;
	public GUIText infoEconomy3;

//	public GUIText weekly;
//	public GUIText paused;
	bool visitedShop;
	public static bool visitedUpgrades;
	public static bool visitedWeekly;
	public static bool visitedEconomy = false;
	bool visitedPapers = false;

	public AudioSource[] sounds;
	public AudioSource loopedSong;
	public AudioSource thumpSound;
	public AudioSource gameOverSound;
	public AudioSource winSound;
	public AudioSource paperSound;

	// Use this for initialization
	void Start () {
		visitedShop = false;
		visitedWeekly = false;

		sounds = GetComponents<AudioSource>();
		loopedSong = sounds [0];
		thumpSound = sounds[1];
		gameOverSound = sounds [2];
		winSound = sounds [3];
		paperSound = sounds [4];

		islandInfo.Start (); //Startvariablene til islandInfo lagres nå
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) { //Tester om spilleren klikker med musa
			//thumpSound.Play ();
			if(pause.isPaused == false){
				//Spilleren klikker med musa,og vi ser om en av øyene klikkes på.
				//Gjøres dette vil vi sette bool visitedX = true for korrekt øy
				//Printer så ut informasjonen til øya i showText();
				if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandFernadina") {
					islandInfo.visitedFernadina = true;
					showText (0);
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandIsabela") {
					islandInfo.visitedIsabela = true;
					showText (1);
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanCristobal") {
					islandInfo.visitedSanCristobal = true;
					showText (2);
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSantaCruz") {
					islandInfo.visitedSantaCruz = true;
					showText (3);
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanSalvador") {
					islandInfo.visitedSanSalvador = true;
					showText (4);
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ocean") {
					oceanInfo.visitedOcean = true;
					showText (5);
				} 

				else if(Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "border"){
					borders();
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "closeShop"){
					if(visitedShop == true){
						shopBox.transform.position = new Vector3 (0, 0, 10);
						shop.text = "";
						//visitedShop = false;
					}
				}
				// Sjekker om man kjøper oppgraderinger
				//registerer trykk på politioppgraderinger
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu1") {
					policeUpgrades.upgradeOne();
					Debug.Log ("treff PU1");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu2") {
					policeUpgrades.upgradeTwo();
					Debug.Log ("treff PU2");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu3") {
					policeUpgrades.upgradeThree();
					Debug.Log ("treff PU3");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu4") {
					policeUpgrades.upgradeFour();
					Debug.Log ("treff PU4");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu5") {
					policeUpgrades.upgradeFive();
					Debug.Log ("treff PU5");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu6") {
					policeUpgrades.upgradeSix();
					Debug.Log ("treff PU6");
				}

				//registerer trykk på turismeoppgraderinger
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu1") {
					touristUpgrades.upgradeOne();
					Debug.Log ("treff TU1");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu2") {
					touristUpgrades.upgradeTwo();
					Debug.Log ("treff TU2");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu3") {
					touristUpgrades.upgradeThree();
					Debug.Log ("treff TU3");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu4") {
					touristUpgrades.upgradeFour();
					Debug.Log ("treff TU4");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu5") {
					touristUpgrades.upgradeFive();
					Debug.Log ("treff TU5");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu6") {
					touristUpgrades.upgradeSix();
					Debug.Log ("treff TU6");
				}
				//registrerer trykk på søppeloppgraderinger
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su1") {
					cleanerUpgrades.upgradeOne();
					Debug.Log ("treff SU1");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su2") {
					cleanerUpgrades.upgradeTwo();
					Debug.Log ("treff SU2");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su3") {
					cleanerUpgrades.upgradeThree();
					Debug.Log ("treff SU3");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su4") {
					cleanerUpgrades.upgradeFour();
					Debug.Log ("treff SU4");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su5") {
					cleanerUpgrades.upgradeFive();
					Debug.Log ("treff SU5");
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su6") {
					cleanerUpgrades.upgradeSix();
					Debug.Log ("treff SU6");
				}

				// trykk på oppgraderingsmenyen
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "upgradeM") 
				{
					Debug.Log ("Oppgraderinger");
					if(visitedUpgrades == false){
						close ();
						upgradeBox.transform.position = new Vector3 (0, 0, 0);
						paperSound.Play();
					}
					visitedUpgrades = true;
				}


				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "shop") {
					if(visitedShop == false){
						close ();
						showShop();
						paperSound.Play();
						visitedShop = true;
					}
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "closeShop"){
					if(visitedShop == true){
						close();
						visitedShop = false;
					}
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "economy") {
					Debug.Log ("økonomi");
					if(visitedEconomy == false){ 
						showEconomy();
						paperSound.Play();
					}
				}

				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "rapport") {
					Debug.Log ("rapporter");
					if(visitedPapers == false){
						close ();
						showAdmin();
						paperSound.Play();
						visitedPapers = true;
					}
				}

				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "buildHotel") {
					Hotel.build();
				}
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "destroyHotel") {
					Hotel.destroy();
				}

				else if(Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "weekly"){
					if(visitedWeekly == false){
						showWeekly();
					}
				}

				else if(Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "blockBack"){
					Debug.Log("lol");
				}

				//Tester om spilleren klikker utenfor informasjonsboksen (er en hitbox der)
				else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "close") {
					close ();
				}
			}

			if(Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "quit"){
				Application.Quit();
			}
			else if(Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "restart"){
				pause.unPause();
				Application.LoadLevel (0);  
			}
		}

	}

	public static void borders(){
		Debug.Log ("Nå kommer grenseland!");
		if (islandInfo.visitedFernadina == true) {
			if (islandInfo.f_isClosed == true) {
				islandInfo.f_isClosed = false;
			} else {
				islandInfo.f_isClosed = true;
			}
		} else if (islandInfo.visitedIsabela == true) {
			if (islandInfo.i_isClosed == true) {
				islandInfo.i_isClosed = false;
			} else {
				islandInfo.i_isClosed = true;
			}
		}
		else if (islandInfo.visitedSanCristobal == true) {
			if (islandInfo.sc_isClosed == true) {
				islandInfo.sc_isClosed = false;
			} else {
				islandInfo.sc_isClosed = true;
			}
		}
		else if (islandInfo.visitedSanSalvador == true) {
			if (islandInfo.ss_isClosed == true) {
				islandInfo.ss_isClosed = false;
			} else {
				islandInfo.ss_isClosed = true;
			}
		}
		else if (islandInfo.visitedSantaCruz == true) {
			if (islandInfo.sz_isClosed == true) {
				islandInfo.sz_isClosed = false;
			} else {
				islandInfo.sz_isClosed = true;
			}
		}
	}

	public void showText(int n){
		infoFernadina.text = "";
		infoSalvador.text = "";
		infoIsabela.text = "";
		infoCruz.text = "";
		infoCristobal.text = "";
		infoHav.text = "";

		switch (n) {
		case 0:
			infoBoxFernadina.transform.position = new Vector3 (0, 0, 0);
			infoFernadina.text += "Populasjon: " + islandInfo.populasjonFernandina;
			infoFernadina.text += "\n";
			infoFernadina.text += "Antall turister: " + islandInfo.turisterFernandina;
			infoFernadina.text += "\n";
			infoFernadina.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngFernandina + Stella_kode.Iguana_FertilFernandina) + "\n";
			infoFernadina.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilFernandina + Stella_kode.Brown_Pelican_FertilFernandina);
			infoFernadina.text += "\n";
			infoFernadina.text += "Mengde søppel: " + islandInfo.forsoplingFernandina;
			infoFernadina.text += "\n";
			infoFernadina.text += "Antall oppryddere: " + islandInfo.ansatteFernadina;
			infoFernadina.text += "\n";
			break;

		case 1:
			infoBoxIsabela.transform.position = new Vector3 (0, 0, 0);
			infoIsabela.text += "Populasjon: " + islandInfo.populasjonIsabela;
			infoIsabela.text += "\n";
			infoIsabela.text += "Antall turister: " + islandInfo.turisterIsabela;
			infoIsabela.text += "\n";
			infoIsabela.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngIsabela + Stella_kode.Iguana_FertilIsabela) + "\n";
			infoIsabela.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilIsabela + Stella_kode.Brown_Pelican_FertilIsabela);
			infoIsabela.text += "\n";
			infoIsabela.text += "Mengde søppel: " + islandInfo.forsoplingIsabela;
			infoIsabela.text += "\n";
			infoIsabela.text += "Antall oppryddere: " + islandInfo.ansatteIsabela;
			infoIsabela.text += "\n";

			break;
		case 2: 
			infoBoxCristobal.transform.position = new Vector3 (0, 0, 0);
			infoCristobal.text += "Populasjon: " + islandInfo.populasjonSanCristobal;
			infoCristobal.text += "\n";
			infoCristobal.text += "Antall turister: " + islandInfo.turisterSanCristobal;
			infoCristobal.text += "\n";
			infoCristobal.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngSanCristobal + Stella_kode.Iguana_FertilSanCristobal) + "\n";
			infoCristobal.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilSanCristobal + Stella_kode.Brown_Pelican_FertilSanCristobal); 
			infoCristobal.text += "\n";
			infoCristobal.text += "Mengde søppel: " + islandInfo.forsoplingSanCristobal;
			infoCristobal.text += "\n";
			infoCristobal.text += "Antall oppryddere: " + islandInfo.ansatteSanCristobal;
			infoCristobal.text += "\n";

			break;
		case 3: 
			infoBoxSalvador.transform.position = new Vector3 (0, 0, 0);
			infoSalvador.text += "Populasjon: " + islandInfo.populasjonSanSalvador;
			infoSalvador.text += "\n";
			infoSalvador.text += "Antall turister: " + islandInfo.turisterSanSalvador;
			infoSalvador.text += "\n";
			infoSalvador.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngSanSalvador + Stella_kode.Iguana_FertilSanSalvador) + "\n";
			infoSalvador.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilSanSalvador + Stella_kode.Brown_Pelican_FertilSanSalvador);
			infoSalvador.text += "\n";
			infoSalvador.text += "Mengde søppel: " + islandInfo.forsoplingSanSalvador;
			infoSalvador.text += "\n";
			infoSalvador.text += "Antall oppryddere: " + islandInfo.ansatteSanSalvador;
			infoSalvador.text += "\n";

			break;
		case 4: 
			infoBoxCruz.transform.position = new Vector3 (0, 0, 0);
			infoCruz.text += "Populasjon: " + islandInfo.populasjonSantaCruz;
			infoCruz.text += "\n";
			infoCruz.text += "Antall turister: " + islandInfo.turisterSantaCruz;
			infoCruz.text += "\n";
			infoCruz.text += "Dyr: Iguana - " + (Stella_kode.Iguana_UngSantaCruz + Stella_kode.Iguana_FertilSantaCruz) + "\n";
			infoCruz.text += "Dyr: Pelican - " + (Stella_kode.Brown_Pelican_FertilSantaCruz + Stella_kode.Brown_Pelican_FertilSantaCruz); 
			infoCruz.text += "\n";
			infoCruz.text += "Mengde søppel: " + islandInfo.forsoplingSantaCruz;
			infoCruz.text += "\n";
			infoCruz.text += "Antall oppryddere: " + islandInfo.ansatteSantaCruz;
			infoCruz.text += "\n";

			break;

		case 5: 
			infoBoxHav.transform.position = new Vector3 (0, 0, 0);
			infoHav.text += "Populasjon: Dette er et hav.";
			infoHav.text += "\n";
			infoHav.text += "Antall turister: Dette er et hav.";
			infoHav.text += "\n";
			infoHav.text += "Mengde søppel: 0";
			infoHav.text += "\n";
			infoHav.text += "Antall politifolk: " + oceanInfo.ansatteOcean;
			infoHav.text += "\n";
			break;

		case 6:
			close ();
			pauseBox.transform.position = new Vector3 (0, 0, 0);
			infoPause.text += "Spillet er pauset." + "\n";
			infoPause.text += "\n";
			infoPause.text += "Klikk på esc knappen for å spille igjen.";
			break; 
		}

	}

	public void showEconomy() {
		close ();
		visitedEconomy = true;
		int money = Stella_kode.maanedligInntekt - (Stella_kode.totAntallOppryddere * 300) - (Stella_kode.Politi * 700);
		economyBox.transform.position = new Vector3 (0, 0, 0);
		infoEconomy.text = "Economy" + "\n";
		infoEconomy.text += "Income" + "\n"+ "\n"+ "\n" + "\n";
		infoEconomy1.color = Color.green; //Grønn tekst for inntekter
		infoEconomy1.text += "From tourists this week: " + (Stella_kode.totTurister * 37) + "\n";
		infoEconomy1.text += "From population this week: " + (Stella_kode.totPopulasjon * 20) + "\n";
		infoEconomy1.text += "Total income this month: " + Stella_kode.maanedligInntekt + "\n" + "\n";
		infoEconomy.text += "Expenses" + "\n";
		infoEconomy2.color += Color.red; //Rød tekst for utgifter
		infoEconomy2.text += "Cleaners: " + (islandInfo.totOppryddere * 300) + "\n";
		infoEconomy2.text += "Police: " + (Stella_kode.Politi * 700) + "\n";
		infoEconomy2.text += "Total expences this month: " + ((islandInfo.totOppryddere * 300) + (Stella_kode.Politi * 700)) + "\n";
		infoEconomy2.text += "\n";
		if (money > 0) {
			infoEconomy3.color = Color.green; //Grønn tekst for inntekter
			infoEconomy3.text += "Total next month: " + money;
		} else {
			infoEconomy3.color = Color.red; //Grønn tekst for inntekter
			infoEconomy3.text += "Total next month: " + money;
		}
	}

	void showShop() {
		visitedShop = true;
		shopBox.transform.position = new Vector3 (4.35f, 0.4825f, 0f);
		shop.text += "Fernandina: " + "\n";
		shop.text += "Isabela: " + "\n";
		shop.text += "San Salvador: " + "\n";
		shop.text += "San Cristobal: " + "\n";
		shop.text += "Santa Cruz: " + "\n";
	}

	public void showAdmin() {
		adminBox.transform.position = new Vector3 (0, 0, 0);
		GameObject.Find ("Slider").transform.position = new Vector3 (1000, 550, 0); 
		infoAdmin.text = "";
		infoAdmin.text = "Max number of turists: " + begrensninger.maxTurister;
		infoAdmin.text += "\n";
	}

	public void gameOver() {
		close ();
		endscreenBox.transform.position = new Vector3 (0, 0, 0);
		infoPause.text += "Du har tapt spillet!" + "\n";
		infoPause.text += "2 av tap kravene ble oppnådd." + "\n";
	}

	public void victory() {
		close ();
		endscreenBox.transform.position = new Vector3 (0, 0, 0);
		infoPause.text += "Du har vunnet spillet!" + "\n";
		infoPause.text += "2 av vinn kravene ble oppnådd." + "\n";
	}

	public void showWeekly(){
/*		visitedWeekly = true;
		weeklybox.transform.position = new Vector3 (0, 0, 0);
		weekly.text = "";

		weekly.text += "Her kommer iguana";
		weekly.text += "\n";
		for (int i = 0; i < weeklyChange.i_numFern; i++) {
			weekly.text += "Uke " + (i+1) + ": " + weeklyChange.igFern[i];
			weekly.text += "\n";
		}

		weekly.text += "Her kommer pelikan";
		weekly.text += "\n";
		for (int i = 0; i < weeklyChange.p_numFern; i++) {
			weekly.text += "Uke " + (i+1) + ": " + weeklyChange.peFern[i];
			weekly.text += "\n";
		}*/
	}

	public void close(){
		infoBoxFernadina.transform.position = new Vector3 (0, 0, 10);
		infoBoxCristobal.transform.position = new Vector3 (0, 0, 10);
		infoBoxIsabela.transform.position = new Vector3 (0, 0, 10);
		infoBoxCruz.transform.position = new Vector3 (0, 0, 10);
		infoBoxSalvador.transform.position = new Vector3 (0, 0, 10);
		infoBoxHav.transform.position = new Vector3 (0, 0, 10);
		adminBox.transform.position = new Vector3 (-1042f, 0f, 10f);
		pauseBox.transform.position = new Vector3 (0, 0, 10);
		economyBox.transform.position = new Vector3 (0, 0, 10);
		GameObject.Find ("Slider").transform.position = new Vector3 (-1365f, 132f, 0); 

		shopBox.transform.position = new Vector3 (0, 0, 10);
		upgradeBox.transform.position = new Vector3 (0, 0, 10);
//		weeklybox.transform.position = new Vector3 (0, 0, 10);
//		pausedBox.transform.position = new Vector3 (0, 0, 10);

		shop.text = "";
		visitedShop = false;
		infoFernadina.text = "";
		infoSalvador.text = "";
		infoIsabela.text = "";
		infoCruz.text = "";
		infoCristobal.text = "";
		infoHav.text = "";
		infoAdmin.text = "";
		infoPause.text = "";
		infoEconomy.text = "";
		infoEconomy1.text = "";
		infoEconomy2.text = "";
		infoEconomy3.text = "";
		visitedWeekly = false;
		visitedEconomy = false;
		visitedPapers = false;
		visitedUpgrades = false;
//		weekly.text = "";
//		paused.text = "";

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