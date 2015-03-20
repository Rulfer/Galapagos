using UnityEngine;
using System.Collections;

public class newsFeed : MonoBehaviour{
	string[] newsArray = new string[5];
	float speed = 0.001f;
	Vector3 startPos;
	public GUIText news;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
		News ();
		pickRanNews ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * speed;
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.tag == "News")
		{
			transform.position = startPos;
			pickRanNews();
			Debug.Log ("hit");
		}
	}

	void News(){
		newsArray[0] = "Ghandi besøker Galapagos og tar med seg 4 pakker med eksplosiver. 'Jeg ønsker å vise jeg er rebell', påstår folk å ha hørt han si.";
		newsArray[1] = "Raptor Jesus har blitt sett på en av øyene. Ny kult har oppstått og populasjonen økt med et par hundre folk.";
		newsArray[2] = "Fiske opplever nedgang, og innbygerne tror det er tyvfiskere sin skyld. Når planlegger staten å gjøre noe med dette?";
		newsArray [3] = "Jeg gikk tom for ideer. Dere andre får skrive noe.";
		newsArray [4] = "Fremdeles tom for ideer, guys. Kan vi inkludere Obamacare på en eller annen måte?";
	}

	void pickRanNews(){
		int ranNum = Random.Range (0, 5);
		news.text = newsArray[ranNum];
		Debug.Log (ranNum);
	}

	void disasterNews(int n){
		news.text = newsArray [n];
	}
}
