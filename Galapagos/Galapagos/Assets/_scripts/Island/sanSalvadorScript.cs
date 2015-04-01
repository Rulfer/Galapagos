﻿using UnityEngine;
using System.Collections;

public class sanSalvadorScript : MonoBehaviour {
	
	public GameObject infoBox;
	public GUIText info;
	public static int ansatte;
	public static int endreAnsatte;
	public static bool visitedSalvador = false;
	// Use this for initialization
	void Start () {
		ansatte = Stella_kode.oppryddereSanSalvador;
		endreAnsatte = ansatte;
	}
	
	// Update is called once per frame
	void Update () {
		if (visitedSalvador == true) {
					
					ansatte = Stella_kode.oppryddereSanSalvador;
					endreAnsatte = ansatte;
					if (ansatte > Stella_kode.oppryddereSanCristobal || ansatte < Stella_kode.oppryddereSanSalvador) {
						showText ();
					}
					if (endreAnsatte > ansatte || endreAnsatte < ansatte) {
						showText ();
					}
				} 
				else {
					close ();
				}
	}
	
	void OnMouseDown(){
		visitedSalvador = true;
		infoBox.transform.position = new Vector3(0, 0, 0);
		showText ();	
		Debug.Log ("visitedSalvador");
		Debug.Log (infoBox.transform.position);
	}
	
	void showText(){
		info.text = "";
		info.text = "San Salvador" + "\n";
		info.text += "\n";
		info.text += "Antall turister på øya: " + "\n";
		info.text += "Antall dyr på øye: " + "\n";
		info.text += "Mengde søppel: " + "\n";
		info.text += "\n";
		info.text += "Antall oppryddere: " + ansatte + "\n";
		info.text += "\n";
		info.text += "\n";
		info.text += "Ansett/Spark ansatte: ANSETT SPARK";
	}
	
		void close(){
			info.text = "";
			infoBox.transform.position = new Vector3(0, 0, 10);
		}
}
