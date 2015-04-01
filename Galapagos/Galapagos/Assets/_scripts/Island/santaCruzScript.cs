using UnityEngine;
using System.Collections;

public class santaCruzScript : MonoBehaviour {
	
	public GameObject infoBox;
	public GUIText info;
	public static int ansatte;
	public static int endreAnsatte;
	public static bool visitedsanta = false;
	// Use this for initialization
	void Start () {
		ansatte = Stella_kode.oppryddereSantaCruz;
		endreAnsatte = ansatte;
	}
	
	// Update is called once per frame
	void Update () {
		if (visitedsanta == true) {
			ansatte = Stella_kode.oppryddereSantaCruz;
			endreAnsatte = ansatte;
			if (ansatte > Stella_kode.oppryddereSantaCruz || ansatte < Stella_kode.oppryddereSantaCruz) {
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
		visitedsanta = true;
		infoBox.transform.position = new Vector3(0, 0, 0);
		showText ();	
		Debug.Log ("santa");
		Debug.Log (infoBox.transform.position);
	}
	
	void showText(){
		info.text = "";
		info.text = "Santa" + "\n";
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
