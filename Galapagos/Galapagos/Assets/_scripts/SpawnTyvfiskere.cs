using UnityEngine;
using System.Collections;
using System;

public class SpawnTyvfiskere : MonoBehaviour {

	public Rigidbody Tyvfisker;
	float randomX;
	float randomY;
	int totTyvfiskere = 0;
	System.Random rnd = new System.Random();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		totTyvfiskere = Stella_kode.Tyvfiskere_Hai + Stella_kode.Tyvfiskere_Sjopolse
		randomX = rnd.Next (-10, 10);
		randomY = rnd.Next (-5, 4);
	
		Instantiate(Tyvfisker, new Vector3(randomX, randomY, 0), Quaternion.identity);
	}
}
