using UnityEngine;
using System.Collections;

public class bankAccount : MonoBehaviour {
	int penger;
	public GameObject infoBox;
	public GUIText info;
	// Use this for initialization
	void Start () {
		penger = Stella_kode.okonomi;
	}
	
	// Update is called once per frame
	void Update () {
		if (Stella_kode.okonomi > penger || Stella_kode.okonomi < penger) {
			penger = Stella_kode.okonomi;
			print ();
		}

		if (penger <= 0) {
			newsFeed.disasterNews (8);
		}
	}

	void print(){
		info.text = "";
		info.text = penger + "$";
	}
}
