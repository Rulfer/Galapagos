using UnityEngine;
using System.Collections;

public class bankAccount : MonoBehaviour {
	public static int penger;
	public GameObject infoBox;
	public GUIText info;
	// Use this for initialization
	void Start () {
		penger = Stella_kode.okonomi;

		print ();
	}
	
	// Update is called once per frame
	void Update () {
		if (pause.isPaused == false) {
			if (Stella_kode.okonomi > penger || Stella_kode.okonomi < penger) {
				penger = Stella_kode.okonomi;
				print ();
			}

			if (penger <= 0) {
				newsFeed.disasterNews (8);
			}
		}
	}

	public void print(){
		info.text = "";
		info.text = penger + "$";
	}
}
