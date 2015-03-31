using UnityEngine;
using System.Collections;

public class mouseClicker : MonoBehaviour {
	string[] islandName = new string[5];
	public GameObject infoBox;
	public GUIText info;
	public static bool visitedIsabela = false;
	bool show = false;

	// Use this for initialization
	void Start () {
		islandName[0] = "Fernadina";
		islandName [1] = "Isabela";
		islandName [2] = "San Cristobal";
		islandName [3] = "Santa Cruz";
		islandName [4] = "San Salvador";
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandFerdinadina") {
				Debug.Log ("treffer Ferdinadina");
				showText(1);
			}
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandIsabela") {
				Debug.Log ("treffer Isabela");
				showText(1);
			}
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanCristobal") {
				Debug.Log ("treffer San Cristobal");
			}
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSantaCruz") {
				Debug.Log ("treffer Santa Cruz");
			}
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "islandSanSalvador") {
				Debug.Log ("treffer San Salvador");
			}
		}

		if (show == true) {
			infoBox.transform.position = new Vector3 (0, 0, 0);
		} else {
			infoBox.transform.position = new Vector3 (0, 0, 10);
		}

	}

	void showText(int n){
		show = true;
		Debug.Log (infoBox.transform.position);
		infoBox.transform.position = new Vector3 (0, 0, 0);

		int i = n;
		Debug.Log (infoBox.transform.position);

//	
//		switch (n) {
//		case 1:

			infoBox.transform.position = new Vector3 (0, 0, 0);
			info.text = "";
			info.text = islandName [n] + "\n";
			info.text += "\n";
			info.text += "Antall turister på øya: " + "\n";
			info.text += "Antall dyr på øye: " + "\n";
			info.text += "Mengde søppel: " + "\n";
			info.text += "\n";
			info.text += "Antall oppryddere: " + fernandinaScript.ansatte + "\n";
			info.text += "\n";
			info.text += "\n";
			info.text += "Ansett/Spark ansatte: ANSETT SPARK";
//			break;
		Debug.Log (infoBox.transform.position);
		//		}
	}
}