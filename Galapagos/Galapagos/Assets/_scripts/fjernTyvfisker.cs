using UnityEngine;
using System.Collections;

public class fjernTyvfisker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter (Collider other)
	{
//		//Etter hvilken side båten er på vil den bli dyttet vekk fra posisjonen til tingen den kolliderer med.
//		if (other.transform.position.x <= transform.position.x && other.transform.position.y <= transform.position.y) {
//			transform.Translate (0.1f, 0.1f, 0);
//		} else if (other.transform.position.x <= transform.position.x && other.transform.position.y >= transform.position.y) {
//			transform.Translate (0.1f, -0.1f, 0);
//		} else if (other.transform.position.x >= transform.position.x && other.transform.position.y >= transform.position.y) {
//			transform.Translate (-0.1f, -0.1f, 0);
//		} else if (other.transform.position.x >= transform.position.x && other.transform.position.y <= transform.position.y) {
//			transform.Translate (-0.1f, 0.1f, 0);
//		}
		if (other.gameObject.tag == "removeTyvfisker") {
			Destroy (other.gameObject);
		}

		Debug.Log ("Enter Hitbox");
	}

	void onCollisionEnter (Collision other)
	{
		//		//Etter hvilken side båten er på vil den bli dyttet vekk fra posisjonen til tingen den kolliderer med.
		//		if (other.transform.position.x <= transform.position.x && other.transform.position.y <= transform.position.y) {
		//			transform.Translate (0.1f, 0.1f, 0);
		//		} else if (other.transform.position.x <= transform.position.x && other.transform.position.y >= transform.position.y) {
		//			transform.Translate (0.1f, -0.1f, 0);
		//		} else if (other.transform.position.x >= transform.position.x && other.transform.position.y >= transform.position.y) {
		//			transform.Translate (-0.1f, -0.1f, 0);
		//		} else if (other.transform.position.x >= transform.position.x && other.transform.position.y <= transform.position.y) {
		//			transform.Translate (-0.1f, 0.1f, 0);
		//		}
		if (other.gameObject.tag == "removeTyvfisker") {
			Destroy (other.gameObject);
		}
		
		Debug.Log ("Enter Hitbox");
	}
}
