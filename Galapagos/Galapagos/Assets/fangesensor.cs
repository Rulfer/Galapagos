using UnityEngine;
using System.Collections;

public class fangesensor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.W))
		    {
		transform.Translate (Vector3.up/20);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate (Vector3.left/20);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate (Vector3.down/20);
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate (Vector3.right/20);
		}

	
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "tyvfisker")
		{
			other.gameObject.SetActive(false);
		}
		Debug.Log ("Tyvfiskere kvelt");
	}

}
