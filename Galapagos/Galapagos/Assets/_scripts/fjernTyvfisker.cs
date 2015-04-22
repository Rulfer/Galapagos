using UnityEngine;
using System.Collections;
using System;

public class fjernTyvfisker : MonoBehaviour {
	//Lagrer en av de 4 retningene
	int randomDir = 0;
	//Lagrer hvor mange sekunder som har gått
	int lagretTid = 0;

	System.Random rnd = new System.Random();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (pause.isPaused == false) {
			if (Stella_kode.timer > lagretTid) {

				//Lager et random tall som skal velge hvilken retning tyvfiskeren vil gå
				randomDir = rnd.Next (0, 4);
				//Skjekker at tyvfiskeren er innenfor grensen
				if (transform.position.x >= -10 && transform.position.x <= 10 && transform.position.y <= 5 && transform.position.y >= -5) {
					//Bruker switch til å translatere
					switch (randomDir) {
					case 0:
						transform.Translate (0.1f, 0.1f, 0);
						break;

					case 1:
						transform.Translate (0.1f, -0.1f, 0);
						break;
					case 2:
						transform.Translate (-0.1f, -0.1f, 0);
						break;
					case 3:
						transform.Translate (-0.1f, 0.1f, 0);
						break;
					}
				}
			}

			lagretTid = (int)Math.Ceiling (Stella_kode.timer);
		}


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
