using UnityEngine;
using System.Collections;

//DENNE KLASSEN ER IKKE BRUKT
// WOLOLO

public class upgrades : MonoBehaviour 
{

	public static bool pu1;
	public static bool pu2;

	public static bool tu1;
	public static bool tu2;

	public static bool su1;
	public static bool su2;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	//oppgraderinger relatert til politi
public static void upgradePoliti ()
	{
		if (Stella_kode.okonomi >= 50000) 
		{
			//denne oppgraderingen øker farten på politibåten man styrer
			if (mouseClicker.visitedUpgrades == true)
			{
				if (pu1 != true)
				{
					pu1 = true;
					fangesensor.boatSpeed -= 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU1-pbåt Speed: ");
					Debug.Log (fangesensor.boatSpeed);
				}
			}

			else if(mouseClicker.visitedUpgrades == true)
			{
				/*if (pu1 != true && pu2 != true && Stella_kode.okonomi >= 100000)
				{
					pu1 = false;
					pu2 = false;
					//Stella_kode.okonomi -= 100000;
					Debug.Log ("pbåt Speed: ");
					Debug.Log(fangesensor.boatSpeed);
				}*/

				if (pu1 == true && pu2 != true)
				{
					pu2 = true;
					fangesensor.boatSpeed -= 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU2-pbåt Speed: ");
					Debug.Log(fangesensor.boatSpeed);
				}
			}
		}
	}

	//oppgraderinger relatert til turister
	public static void upgradeTurisme ()

	{
		if (Stella_kode.okonomi >= 50000) {

			if (mouseClicker.visitedUpgrades == true) {
				if (tu1 != true) {
					tu1 = true;
					Stella_kode.pengerFraTurister += 10;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("TU1-turister betaler: ");
					Debug.Log (Stella_kode.pengerFraTurister);
				}	
			}
		
			if (mouseClicker.visitedUpgrades == true) {

				if (Stella_kode.okonomi >= 50000) {

					if (tu1 == true && tu2 != true) {
						tu2 = true;
						Stella_kode.pengerFraTurister += 10;
						Stella_kode.okonomi -= 50000;
						Debug.Log ("TU2-turister betaler: ");
						Debug.Log (Stella_kode.pengerFraTurister);
					}
			
					/*	else if (tu1 != true && tu2 != true && Stella_kode.okonomi >= 100000)
		
			{
				tu1 = false;
				tu2 = false;
				//Stella_kode.okonomi -= 0;
				Debug.Log ("turister betaler: ");
				Debug.Log(Stella_kode.pengerFraTurister);
			}	*/
				}
			}
		}
	}

	//oppgraderinger relatert til søppel
	public static void upgradeSoppel ()

	{
		if (Stella_kode.okonomi >= 50000)
		{

		if (mouseClicker.visitedUpgrades == true)
		{
			if (su1 != true)
			{
				su1 = true;
				Stella_kode.oppryddereRydder += 5;
				Stella_kode.okonomi -= 50000;
				Debug.Log ("SU1-oppryddere rydder: ");
				Debug.Log (Stella_kode.oppryddereRydder);
			}	
		}
		
		if(mouseClicker.visitedUpgrades == true)
		{
			if (su1 == true && su2 != true)
			{
				su2 = true;
				Stella_kode.oppryddereRydder += 5;
				Stella_kode.okonomi -= 50000;
				Debug.Log ("SU2-oppryddere rydder: ");
				Debug.Log(Stella_kode.oppryddereRydder);
			}
			
		/*	else if (su1 != true && su2 != true && Stella_kode.okonomi >= 100000)
			{
				su1 = false;
				su2 = false;
				//Stella_kode.okonomi -= 0;
				Debug.Log ("oppryddere rydder: ");
				Debug.Log(Stella_kode.oppryddereRydder);
			}	*/
			}
		}
	}
}
