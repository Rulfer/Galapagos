using UnityEngine;
using System.Collections;

public class newsFeed : MonoBehaviour{
	public static string[] newsArray = new string[21]; //Array that contains all news
	public static string[] newsImportantArray = new string[100]; //Array that contains queued important news
	public static int newsQueue = 0; //Used to tell how many important news that are queued
	bool first = true;

	float speed = 0.0015f; //The speed of the newsfeed
	Vector3 startPos; //Remembers the starting position of the news
	public GUIText news;


	// Use this for initialization
	void Start () {
		startPos = transform.position; //Saves the starting location
		News (); //Creates the news array
		printNews (); //Unleash the news!
	}
	
	//Sørker for at newsfeed beveger seg uavhengig av FPS'en
	void FixedUpdate () {
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
		newsArray [0] = "Game Developer finds a home on Galapagos. The population looks at him with disgust.";
		newsArray [1] = "Gandhi visits Galapagos and brings 4 bags with explosives. People heard him say 'I wish to show how rebel I can be'.";
		newsArray [2] = "Fiske opplever nedgang, og innbygerne tror det er tyvfiskere sin skyld. Når planlegger staten å gjøre noe med dette?";
		newsArray [3] = "Scientist agree, there is no way of explaining how boats float.";
		newsArray [4] = "The people of Galapagos are frightened by the possible threat of Obamacare. What would happen if it reached the islands?";
		newsArray [5] = "Important news! A cruise drove by Galapagos and decided to camp on one of the islands. Large ammounts of trash left behind.";
		newsArray [6] = "Important news! Bastard Airlines offers free travel to Galapagos, so expect more turists than expected.";
		newsArray [7] = "Important news! Tanker hit ground and is now spilling toxic waste! As a result a whole 30% of the shark and sea cucumber population has died."; 
		newsArray [8] = "Important news! Raptor Jesus has been spotted on one of the islands, causing a new cult and increased population on that island.";
		newsArray [9] = "Important news! Lav populasjon av hai har gjort den ettertraktet på svartemarkedet. Myndighetene håper de har nok politi til å stoppe tyvfiskerne.";
		newsArray [10] = "Important news! Galapagos are having economical issues. How will the government solve this?";
		newsArray [11] = "Important news! Iguanas on Fernandina struggles, and has fallen bellow 20% of it's original population!";
		newsArray [12] = "Important news! Iguanas on Isabela struggles, and has fallen bellow 20% of it's original population!";
		newsArray [13] = "Important news! Iguanas on San Cristobal struggles, and has fallen bellow 20% of it's original population!";
		newsArray [14] = "Important news! Iguanas on San Salvador struggles, and has fallen bellow 20% of it's original population!";
		newsArray [15] = "Important news! Iguanas on Santa Cruz struggles, and has fallen bellow 20% of it's original population!";
		newsArray [16] = "Important news! Pelicans on Fernandina struggles, and has fallen bellow 20% of it's original population!";
		newsArray [17] = "Important news! Pelicans on Isabela struggles, and has fallen bellow 20% of it's original population!";
		newsArray [18] = "Important news! Pelicans on San Cristobal struggles, and has fallen bellow 20% of it's original population!";
		newsArray [19] = "Important news! Pelicans on San Salvador struggles, and has fallen bellow 20% of it's original population!";
		newsArray [20] = "Important news! Pelicans on Santa Cruz struggles, and has fallen bellow 20% of it's original population!";
	}

	void pickRanNews(){ //If there are no important news then a random funny one will be displayed
		int ranNum = Random.Range (1, 5); //A random number between 0 and 5 are generated, meaning 0 - 4 in the array
		news.color = Color.black;
		if (first == true) {
			news.text = newsArray [0]; //Print the news to the screen
			first = false;
		} else {
			news.text = newsArray [ranNum];
		} //Print the news to the screen
	}

	//Use this function to queue important news
	//Are there a lot of pirates? Then send in the n value that represent the newsArray you want to reach
	public static void disasterNews(int n){
		if (newsQueue == 0) {
			newsImportantArray [newsQueue] = newsArray [n]; //Saves the news
			newsQueue ++; //Increases the queue
		} else {
			for (int i = 0; i < newsQueue; i++) { //Checks of the news is already in the queue
				if (newsImportantArray [newsQueue] != newsImportantArray [n]) { //If its not then it will be saved
					newsImportantArray [newsQueue] = newsArray [n]; //Saves the news
					newsQueue ++; //Increases the queue
				} else {
					//Denne finnes alt
				}
			}
		}
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
			news.color = Color.black; //Default color

		}
	}
}
