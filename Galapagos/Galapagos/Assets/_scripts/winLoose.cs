using UnityEngine;
using System.Collections;

public class winLoose : MonoBehaviour {
	static int looseMoney = 0; //Variabel som teller om spilleren skal tape pga penger
	static int lanimal = 0; //Variabel som teller om spilleren skal tape pga dyr
	static int ltourism = 0; //Variabel som teller om spilleren skal tape pga turisme

	static int wmoney = 0; //Variabel som teller om spilleren skal vinne pga penger
	static int wanimal = 0; //Variabel som teller om spilleren skal vinne pga dyr
	static int wtourism = 0; //Variabel som teller om spilleren skal vinne pga turisme

	static int testMoneyLoose = 0;
	static int testAnimalLoose = 0;
	static int testTourismLoose = 0;
	static int testMoneyWin = 0;
	static int testAnimalWin = 0;
	static int testTourismWin = 0;

	static int loose; //Holder på hvor mange tap-kriterier som er oppnådd
	static int win; //Holder på hvor mange vinn-kriterier som er oppnådd

	public static bool endGame = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		win = testAnimalWin + testMoneyWin + testTourismWin;
		loose = testAnimalLoose + testMoneyLoose + testTourismLoose;

		if (loose >= 2) {
			gameOver ();
			loose = 0;
		}

		if (win >= 2) {
			victory();
			win = 0;
		}

	}

	//Får beslked fra Stella_Kode om spilleren gikk i 0 denne måneden eller ei
	//GIkk spilleren i 0 etter å ha betalt lønninger øker looseMoney med 1
	//Om ikke settes denne lik 0
	public static void checkMoney(bool money, bool greatMoney){
		if (money == true) {looseMoney ++;} 
		else {looseMoney = 0;}

		if(greatMoney == true) {wmoney ++;}
		else {wmoney --;}

		if(looseMoney >= 3){testMoneyLoose = 1;} //Dersom spilleren gikk i null 3 måneder på rad tapes spillet
		else {testMoneyLoose = 0;}
		if(wmoney >= 3){testMoneyWin = 1;}
		else {testMoneyWin = 0;}
	}

	//Får beskjed om det er misnt 3 utrydningstruede dyr og nesten ingen turisme
	//Er animal true øker lanimal med 1, samme gjelder tourism.
	public static void checkAnimalTourism(bool animal, bool tourism, bool healthyAnimals, bool greatTourism)
	{
		if (animal == true) {lanimal ++;} 
		else{lanimal = 0;}
		
		if (tourism == true) {ltourism ++;} 
		else {ltourism = 0;}

		if (healthyAnimals == true) {wanimal ++;}
		else {wanimal = 0;}

		if(greatTourism == true) {wtourism ++;}
		else {wtourism = 0;}

		//Har dyrene vært nesten helt død i 3 uker, eller spilleren mistet omtrent all turisme i 3 uker, økes tap med 1.
		if(lanimal >= 3){testAnimalLoose = 1;}
		else {testAnimalLoose = 0;}
		if(ltourism >= 3){testTourismLoose = 0;}
		else {testTourismLoose = 0;}

		//Er dyrene på minst 50% av sin populasjon i 3 uker, eller det er minst 2000 turister sammenhengende i 3 uker, økes win med 1.
		if(wanimal >= 3){testAnimalWin = 1;}
		else {testAnimalWin = 0;}
		if(wtourism >= 3){testTourismWin = 1;}
		else {testTourismWin = 0;}
	}

	//Aktiverer game over skjermen, samt pauser spillet
	void gameOver(){
		endGame = true;
		GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().gameOver ();
		pause.pauseGame ();
	}

	//Aktiverer vinn skjermer, samt pauser spillet
	void victory(){
		endGame = true;
		GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().victory ();
		pause.pauseGame ();
	}

}
