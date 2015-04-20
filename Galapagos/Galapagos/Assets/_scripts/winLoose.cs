using UnityEngine;
using System.Collections;

public class winLoose : MonoBehaviour {
	public GameObject go;
	static int looseMoney = 0;
	static int lanimal = 0;
	static int ltourism = 0;

	static int loose;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (loose >= 2) {
			gameOver ();
			loose = 0;
		}

	}
	
	public static void checkMoney(bool money){
		if (money == true) {
			looseMoney += 1;
		} else {
			looseMoney = 0;
		}

		if(looseMoney >= 3){loose ++;}
	}

	public static void checkAnimalTourism(bool animal, bool tourism)
	{
		if (animal == true) {
			lanimal++;
		} else{
			lanimal --;}
		
		if (tourism == true) {
			ltourism++;
		} else {
			ltourism --;
		}
		
		if(lanimal <= 0) { lanimal = 0;}
		if(ltourism <= 0) { ltourism = 0;}
		
		if(lanimal >= 3){loose ++;}
		if(ltourism >= 3){loose ++;}
	}

	void gameOver(){
		pause.pauseGame ();
		GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().close ();
	}

}
