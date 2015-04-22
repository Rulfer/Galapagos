using UnityEngine;
using System.Collections;

public class policeUpgrades : MonoBehaviour {

	public static bool pu1 = false;
	public static bool pu2 = false;
	public static bool pu3 = false;	
	public static bool pu4 = false;
	public static bool pu5 = false;	
	public static bool pu6 = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void upgradeOne ()
	{
		if (Stella_kode.okonomi >= 50000) {
			//denne oppgraderingen øker farten på politibåten man styrer
			if (mouseClicker.visitedUpgrades == true) {
				if (pu1 != true) {
					pu1 = true;
					fangesensor.boatSpeed -= 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU1-pbåt Speed: " + fangesensor.boatSpeed);
					//Debug.Log (fangesensor.boatSpeed);
				}
			}
		}
	}

	public static void upgradeTwo () 
	{
		if (Stella_kode.okonomi >= 50000) {

			if (mouseClicker.visitedUpgrades == true) {

				if (pu1 == true && pu2 != true) {
					pu2 = true;
					fangesensor.boatSpeed -= 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU2-pbåt Speed: " + fangesensor.boatSpeed);
					//Debug.Log (fangesensor.boatSpeed);
				}
			}
		}
	}

	public static void upgradeThree () 
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				
				if (pu2 == true && pu4 != true) {
					pu3 = true;
					fangesensor.boatSpeed -= 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU3-pbåt Speed: " + fangesensor.boatSpeed);
					//Debug.Log (fangesensor.boatSpeed);
				}
			}
		}
	}

	public static void upgradeFour ()
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				
				if (pu3 == true && pu4 != true) {
					pu4 = true;
					fangesensor.boatSpeed -= 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU4-pbåt Speed: " + fangesensor.boatSpeed);
					//Debug.Log (fangesensor.boatSpeed);
				}
			}
		}
	}

	public static void upgradeFive ()
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				
				if (pu4 == true && pu5 != true) {
					pu5 = true;
					fangesensor.boatSpeed -= 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU5-pbåt Speed: " + fangesensor.boatSpeed);
					//Debug.Log (fangesensor.boatSpeed);
				}
			}
		}
	}

	public static void upgradeSix ()
	{
		if (Stella_kode.okonomi >= 50000) {
			
			if (mouseClicker.visitedUpgrades == true) {
				
				if (pu5 == true && pu6 != true) {
					pu6 = true;
					fangesensor.boatSpeed -= 5;
					Stella_kode.okonomi -= 50000;
					Debug.Log ("PU6-pbåt Speed: " + fangesensor.boatSpeed);
					//Debug.Log (fangesensor.boatSpeed);
				}
			}
		}
	}

}
