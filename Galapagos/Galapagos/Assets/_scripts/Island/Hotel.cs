using UnityEngine;
using System.Collections;

public class Hotel : MonoBehaviour {

	public static void build(){
		Debug.Log ("Bygger hotell");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.maxTurismeIsabela += 1000;
			Debug.Log ("Bygger isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.maxTurismeFernandina += 1000;
			Debug.Log ("Bygger fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.maxTurismeSanCristobal += 1000;
			Debug.Log ("Bygger san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.maxTurismeSanSalvador += 1000;
			Debug.Log ("Bygger san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.maxTurismeSantaCruz += 1000;
			Debug.Log ("Bygger santa cruz");
		}
		Stella_kode.okonomi-= 2000;
	}

	public static void destroy(){
		Debug.Log ("Ødelegger hotell");
		if (islandInfo.visitedIsabela == true) {
			islandInfo.maxTurismeIsabela -= 1000;
			Debug.Log ("Ødelegger isabela");
		} 
		else if (islandInfo.visitedFernadina == true) {
			islandInfo.maxTurismeFernandina -= 1000;
			Debug.Log ("Ødelegger fernadina");
		} 
		else if (islandInfo.visitedSanCristobal == true) {
			islandInfo.maxTurismeSanCristobal -= 1000;
			Debug.Log ("Ødelegger san cristobal");
		} 
		else if (islandInfo.visitedSanSalvador == true) {
			islandInfo.maxTurismeSanSalvador -= 1000;
			Stella_kode.oppryddereSanSalvador += 1;
			Debug.Log ("Ødelegger san salvador");
		} 
		else if (islandInfo.visitedSantaCruz == true) {
			islandInfo.maxTurismeSantaCruz -= 1000;
			Debug.Log ("Ødelegger santa cruz");
		}
	}
}
