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
		if (other.gameObject.tag == "tyvfisker")
		{
			other.gameObject.SetActive(false);
			Debug.Log ("Tyvfiskere kvelt");
		}
	}

	void OnCollisionEnter(Collision other)
	{
			onIsland = true;
		Debug.Log ("Kollider!");
	}

	void OnCollisionStay (Collision other)
	{
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
		onIsland = false;
	}

}
