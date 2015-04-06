using UnityEngine;
using System.Collections;
using System;

public class SpawnTyvfiskere : MonoBehaviour {

	//Importerer prefab som skal spawnes
	public Rigidbody Tyvfisker;

	//Lager variabler for random x og y verdier
	float randomX;
	float randomY;
	int totTyvfiskerBaat = 0;
	//Antall båter som eksisterer
	public static int antallBater = 0;

	//Brukt til å se hvor mange båter som vil spawne, og is såfall redusere eller ikke
	public int fiskerePrBaat = 10;

	//Bruker Random funksjonen i System klassen i unity. 
	System.Random rnd = new System.Random();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Henter hvor mange tyvfiskere det er fra Stella koden
		totTyvfiskerBaat = (int)(Stella_kode.Tyvfiskere_Hai + Stella_kode.Tyvfiskere_Sjopolse)/fiskerePrBaat;
		Debug.Log ("Totalt tyvfiskere er " + totTyvfiskerBaat);

		if (totTyvfiskerBaat > 0 && totTyvfiskerBaat > antallBater)
		{
		//Lager random nummer mellom grensene satt
		randomX = rnd.Next (-10, 10);
		randomY = rnd.Next (-5, 4);
		//Spawner en ny tyvfisker båt
		Instantiate(Tyvfisker, new Vector3(randomX, randomY, 0), Quaternion.identity);
			antallBater ++;
		}
	}
}
