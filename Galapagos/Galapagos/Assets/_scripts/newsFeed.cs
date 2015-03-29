using UnityEngine;
using System.Collections;

public class newsFeed : MonoBehaviour{
	public static string[] newsArray = new string[9]; //Array that contains all news
	public static string[] newsImportantArray = new string[20]; //Array that contains queued important news
	public static int newsQueue = 0; //Used to tell how many important news that are queued


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
		}
	}

	void News(){ //All the news in the game!
		newsArray[0] = "Ghandi besøker Galapagos og tar med seg 4 pakker med eksplosiver. 'Jeg ønsker å vise jeg er rebell', påstår folk å ha hørt han si.";
		newsArray[1] = "Raptor Jesus har blitt sett på en av øyene. Ny kult har oppstått og populasjonen økt med et par hundre folk.";
		newsArray[2] = "Fiske opplever nedgang, og innbygerne tror det er tyvfiskere sin skyld. Når planlegger staten å gjøre noe med dette?";
		newsArray [3] = "Jeg gikk tom for ideer. Dere andre får skrive noe.";
		newsArray [4] = "Fremdeles tom for ideer, guys. Kan vi inkludere Obamacare på en eller annen måte?";
		newsArray [5] = "Important news! Et cruise kjørte forbi Galapagos og campet på en av øyene. Store mengder søppel er lagt igjen.";
		newsArray [6] = "Important news! Flyselskap tilbyr gratis reiser til Galapagos, så store mengder turister er forventet.";
		newsArray [7] = "Important news! Lav populasjon av hai har gjort den ettertraktet på svartemarkedet. Myndighetene håper de har nok politi til å stoppe tyvfiskerne.";
		newsArray [8] = "Important news! .";
		newsArray [9] = "Important news! .";
	}

	void pickRanNews(){ //If there are no important news then a random funny one will be displayed
		int ranNum = Random.Range (0, 5); //A random number between 0 and 5 are generated, meaning 0 - 4 in the array
		news.color = Color.green;
		news.text = newsArray[ranNum]; //Print the news to the screen
		Debug.Log (ranNum);
	}

	//Use this function to queue important news
	//Are there a lot of pirates? Then send inn the n value that represent the newsArray you want to reach
	public static void disasterNews(int n){
		newsImportantArray [newsQueue] = newsArray [n]; //Saves the news
		Debug.Log ("newsImportantArray" + "[" + newsQueue + "]: " + newsImportantArray[newsQueue]);
		Debug.Log ("Newsqueue: " + newsQueue);
		newsQueue ++; //Increases the queue
	}

	void printNews(){
		if (newsQueue >= 1) {
			news.color = Color.red; //Changes the color of the text as the news are important
			news.text = newsImportantArray[0];
			Debug.Log(newsImportantArray[0]);
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
