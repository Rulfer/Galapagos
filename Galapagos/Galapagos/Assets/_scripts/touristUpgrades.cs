using UnityEngine;
using System.Collections;

public class touristUpgrades : MonoBehaviour {

	public static bool tu1 = false;
	public static bool tu2 = false;
	public static bool tu3 = false;
	public static bool tu4 = false;
	public static bool tu5 = false;
	public static bool tu6 = false;


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
				if (tu1 != true) {
					tu1 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU1-turister betaler: " + Stella_kode.pengerFraTurister);
				}	
			}
		}
	}
	
	public static void upgradeTwo ()
	{
		if (Stella_kode.okonomi >= 50000) {
				
			if (mouseClicker.visitedUpgrades == true) {
					
				if (tu1 == true && tu2 != true) {
					tu2 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU2-turister betaler: " + Stella_kode.pengerFraTurister);
				}
			}
		}
	}

	
	public static void upgradeThree () 
	{
		if (Stella_kode.okonomi >= 50000) {
				
			if (mouseClicker.visitedUpgrades == true) {
					
				if (tu2 == true && tu3 != true) {
					tu3 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU3-turister betaler: " + Stella_kode.pengerFraTurister);
				}
			}
		}
	}

	
	public static void upgradeFour ()
	{
		if (Stella_kode.okonomi >= 50000) {
				
			if (mouseClicker.visitedUpgrades == true) {
					
				if (tu3 == true && tu4 != true) {
					tu4 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU3-turister betaler: " + Stella_kode.pengerFraTurister);
				}
			}
		}
	}

	
	public static void upgradeFive ()
	{
		if (Stella_kode.okonomi >= 50000) {
				
			if (mouseClicker.visitedUpgrades == true) {
					
				if (tu4 == true && tu5 != true) {
					tu5 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU3-turister betaler: " + Stella_kode.pengerFraTurister);
				}
			}
		}
	}

	
	public static void upgradeSix ()
	{
		if (Stella_kode.okonomi >= 50000) {
				
			if (mouseClicker.visitedUpgrades == true) {
					
				if (tu5 == true && tu6 != true) {
					tu6 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU3-turister betaler: " + Stella_kode.pengerFraTurister);
				}
			}
		}
	}
}