using UnityEngine;
using System.Collections;

public class oceanInfo : MonoBehaviour {

	public static int ansatteOcean;//Variabler som sier hvor mange politifolk spilleren har på havet
	public static int a_endretOcean;//Denne variabelen oppdateres dersom det sparkes eller ansettes nye folk
	public static bool visitedOcean;//Brukes for å si hvilken informasjon til hvilken øy spilleren er ute etter

	// Use this for initialization
	void Start () {
		ansatteOcean = 100;
		a_endretOcean = ansatteOcean;
		visitedOcean = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (a_endretOcean < ansatteOcean || a_endretOcean > ansatteOcean) {
			if(a_endretOcean <= 0){
				ansatteOcean = 0;
				a_endretOcean = ansatteOcean;
			}
			else{
				ansatteOcean = a_endretOcean;
			}
			Debug.Log ("ansatte" + ansatteOcean);
			GameObject.Find("MainCamera").GetComponent<mouseClicker>().showText(5);
		}
	}
}