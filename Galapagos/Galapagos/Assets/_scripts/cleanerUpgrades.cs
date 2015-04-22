using UnityEngine;
using System.Collections;

public class cleanerUpgrades : MonoBehaviour {

	public static bool su1;
	public static bool su2;
	public static bool su3;
	public static bool su4;
	public static bool su5;
	public static bool su6;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void upgradeOne () 
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				if (su1 != true) {
					su1 = true;
					Stella_kode.oppryddereRydder += 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("SU1-oppryddere rydder: " + Stella_kode.oppryddereRydder);
				}
			}
		}
	}
	
	public static void upgradeTwo ()
	{
		if (Stella_kode.okonomi >= 50000) {

			if (mouseClicker.visitedUpgrades == true) {
				if (su1 == true && su2 != true) {
					su2 = true;
					Stella_kode.oppryddereRydder += 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("SU2-oppryddere rydder: " + Stella_kode.oppryddereRydder);
					//Debug.Log (Stella_kode.oppryddereRydder);
				}
			}
		}
	}

	public static void upgradeThree () 
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				if (su2 == true && su3 != true) {
					su3 = true;
					Stella_kode.oppryddereRydder += 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("SU3-oppryddere rydder: " + Stella_kode.oppryddereRydder);
					//Debug.Log (Stella_kode.oppryddereRydder);
				}
			}
		}
	}
	
	public static void upgradeFour ()
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				if (su3 == true && su4 != true) {
					su4 = true;
					Stella_kode.oppryddereRydder += 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("SU4-oppryddere rydder: " + Stella_kode.oppryddereRydder);
					//Debug.Log (Stella_kode.oppryddereRydder);
				}
			}
		}
	}
	
	public static void upgradeFive ()
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				if (su4 == true && su5 != true) {
					su5 = true;
					Stella_kode.oppryddereRydder += 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("SU5-oppryddere rydder: " + Stella_kode.oppryddereRydder);
					//Debug.Log (Stella_kode.oppryddereRydder);
				}
			}
		}
	}
	
	public static void upgradeSix ()
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				if (su5 == true && su6 != true) {
					su6 = true;
					Stella_kode.oppryddereRydder += 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("SU6-oppryddere rydder: " + Stella_kode.oppryddereRydder);
					//Debug.Log (Stella_kode.oppryddereRydder);
				}
			}
		}
	}
}
