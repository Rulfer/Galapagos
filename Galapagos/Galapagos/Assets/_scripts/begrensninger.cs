using UnityEngine;
using System.Collections;

public class begrensninger : MonoBehaviour {

	//Lager public variabler andre klasser skal motta
	//Det er disse variablene som tilsvarer begrensningene
	public static float maxTurister = 10000f; //Begrenser maks antall turister på Galapagos

	// Use this for initialization
	void Start () {
		GameObject.Find ("Slider").transform.position = new Vector3 (-1365f, 132f, 0); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void adjustTurister(float newMaxTurisme){ //Slideren endrer maks antall tursiter på Galapagos
		maxTurister = newMaxTurisme * 100;
		GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showAdmin (); 
	}
}
