using UnityEngine;
using System.Collections;

public class fangesensor : MonoBehaviour {

	public static bool onIsland = false;
	public static int boatSpeed = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//Sjekker om båten har krasjet med en øy. Hvis den ikke er det kan den styres som vanlig
		if (onIsland == false) {
			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector3.up / boatSpeed);
			}

			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (Vector3.left / boatSpeed);
			}

			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (Vector3.down / boatSpeed);
			}

			if (Input.GetKey (KeyCode.D)) {
				transform.Translate (Vector3.right / boatSpeed);
			}
		} 

	}
	
	void OnTriggerEnter(Collider other) 
	{
		//Når triggeren rundt båten treffer en tyvfisker så forsvinner den
		if (other.gameObject.tag == "tyvfisker")
		{
			Destroy(other.gameObject);
			Stella_kode.Tyvfiskere_Hai -= 1;
			Stella_kode.Tyvfiskere_Sjopolse -= 9;
			SpawnTyvfiskere.antallBater --;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		//Når båten koliderer med noe (Er bare øyer å kolidere med) så skal onIsland puttes til true,
		onIsland = true;
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
