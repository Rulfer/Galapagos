using UnityEngine;
using System.Collections;

public class fangesensor : MonoBehaviour {

	public static bool onIsland = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Sjekker om båten har krasjet med en øy. Hvis den ikke er det kan den styres som vanlig
		if (onIsland == false) {
			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector3.up / 20);
			}

			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (Vector3.left / 20);
			}

			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (Vector3.down / 20);
			}

			if (Input.GetKey (KeyCode.D)) {
				transform.Translate (Vector3.right / 20);
			}
		} 

		Debug.Log ("Er båten på øya?: " + onIsland);
	}
	
	void OnTriggerEnter(Collider other) 
	{
		//Når triggeren rundt båten treffer en tyvfisker så forsvinner den
		if (other.gameObject.tag == "tyvfisker")
		{
			other.gameObject.SetActive(false);
			Stella_kode.Tyvfiskere_Hai -= 1;
			Stella_kode.Tyvfiskere_Sjopolse -= 9;
			SpawnTyvfiskere.antallBater --;
			Debug.Log ("Tyvfiskere kvelt");
		}
	}

	void OnCollisionEnter(Collision other)
	{
		//Når båten koliderer med noe (Er bare øyer å kolidere med) så skal onIsland puttes til true,
		onIsland = true;
		Debug.Log ("Kollider!");
	}

	void OnCollisionStay (Collision other)
	{
		//Etter hvilken side båten er på vil den bli dyttet vekk fra posisjonen til tingen den kolliderer med.
		if (other.transform.position.x <= transform.position.x && other.transform.position.y <= transform.position.y) {
			transform.Translate (0.1f, 0.1f, 0);
		} else if (other.transform.position.x <= transform.position.x && other.transform.position.y >= transform.position.y) {
			transform.Translate (0.1f, -0.1f, 0);
		} else if (other.transform.position.x >= transform.position.x && other.transform.position.y >= transform.position.y) {
			transform.Translate (-0.1f, -0.1f, 0);
		} else if (other.transform.position.x >= transform.position.x && other.transform.position.y <= transform.position.y) {
			transform.Translate (-0.1f, 0.1f, 0);
		}

	}

	void OnCollisionExit (Collision other)
	{
		//Når båten forlater kollisjonen skal denne puttes til false igjen.
		onIsland = false;
	}

}
