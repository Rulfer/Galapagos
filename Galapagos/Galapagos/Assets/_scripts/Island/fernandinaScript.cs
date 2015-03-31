using UnityEngine;
using System.Collections;

public class fernandinaScript : MonoBehaviour {

	public GameObject infoBox;
	public GUIText info;
	public static int ansatte;
	public static int endreAnsatte;
	public static bool visitedFernadina = false;
	// Use this for initialization
	void Start () {
		ansatte = Stella_kode.Oppryddere;
		endreAnsatte = ansatte;
	}
	
	// Update is called once per frame
	void Update () {
//		if (visitedFernadina == true) {
//			
//			ansatte = Stella_kode.Oppryddere;
//			endreAnsatte = ansatte;
//			if (ansatte > Stella_kode.Oppryddere || ansatte < Stella_kode.Oppryddere) {
//				showText ();
//			}
//			if (endreAnsatte > ansatte || endreAnsatte < ansatte) {
//				showText ();
//			}
//		} 
//		else {
//			close ();
//		}
	}
	
	void showText(){
		infoBox.transform.position = new Vector3(0, 0, 0);

		info.text = "";
		info.text = "Ferdanina" + "\n";
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
	
//	void close(){
//		info.text = "";
//		infoBox.transform.position = new Vector3(0, 0, 10);
//	}
}