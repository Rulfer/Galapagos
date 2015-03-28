using UnityEngine;
using System.Collections;

public class newsFeed : MonoBehaviour{
	string[] newsArray = new string[7]; //Array that contains all news
	string[] newsImportantArray = new string[10]; //Array that contains queued important news
	public int newsQueue = 0; //Used to tell how many important news that are queued


	float speed = 0.001f; //The speed of the newsfeed
	Vector3 startPos; //Remembers the starting position of the news
	public GUIText news;


	// Use this for initialization
	void Start () {
		startPos = transform.position; //Saves the starting location
		News (); //Creates the news array
		printNews (); //Unleash the news!
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * speed;
	}

	void OnTriggerEnter(Collider other) //Restarts the newsbox. A simple hitbox
	{
		if(other.gameObject.tag == "News")
		{
			transform.position = startPos; //Moves the newsbox to the starting position
			printNews(); //Time to print some new news
			Debug.Log ("hit");
		}
	}

	void News(){ //All the news in the game!
		newsArray[0] = "Ghandi besøker Galapagos og tar med seg 4 pakker med eksplosiver. 'Jeg ønsker å vise jeg er rebell', påstår folk å ha hørt han si.";
		newsArray[1] = "Raptor Jesus har blitt sett på en av øyene. Ny kult har oppstått og populasjonen økt med et par hundre folk.";
		newsArray[2] = "Fiske opplever nedgang, og innbygerne tror det er tyvfiskere sin skyld. Når planlegger staten å gjøre noe med dette?";
		newsArray [3] = "Jeg gikk tom for ideer. Dere andre får skrive noe.";
		newsArray [4] = "Fremdeles tom for ideer, guys. Kan vi inkludere Obamacare på en eller annen måte?";
		newsArray [5] = "Important news 1.";
		newsArray [6] = "Important news 2.";
	}

	void pickRanNews(){ //If there are no important news then a random funny one will be displayed
		int ranNum = Random.Range (0, 5); //A random number between 0 and 5 are generated, meaning 0 - 4 in the array
		news.color = Color.green;
		news.text = newsArray[ranNum]; //Print the news to the screen
		Debug.Log (ranNum);
	}

	//Use this function to queue important news
	//Are there a lot of pirates? Then send inn the n value that represent the newsArray you want to reach
	void disasterNews(int n){ 
		newsQueue ++; //Increases the queue
		newsImportantArray [newsQueue] = newsArray [n]; //Saves the news
	}

	void printNews(){
		if (newsQueue >= 1) {
			news.color = Color.red; //Changes the color of the text as the news are important
			news.text = newsImportantArray[0];
			newsQueue --; //Decrese as the neews has been shown

			newsImportantArray[0] = null; //Removes the now used news

			if(newsQueue >= 1){ //Testing if there are more news in the queue
				for(int i = 0; i < newsQueue; i++){
					newsImportantArray[i] = null; //First we empty the point in the array
					newsImportantArray[i] = newsImportantArray[i+1]; //Copies /moves down the array by 1
				}
				newsImportantArray[newsQueue] = null; //Removes the last point in the array as this is now moved further down to 0
			}
		}
		else{
			pickRanNews();
		}
	}
}
