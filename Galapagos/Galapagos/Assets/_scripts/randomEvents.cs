using UnityEngine;
using System.Collections;

public class randomEvents : MonoBehaviour {
	public float timer;
	public float timerLimit = 5.0f;

	// Use this for initialization
	void Start () {
		timer = timerLimit;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0.0f) {
			createEvents();
		}
	}

	public void createEvents(){
		int i = Random.Range (1, 6);

		switch (i) {
		case 1:
			newsFeed.disasterNews(5);
			break;
		case 2:
			newsFeed.disasterNews(6);
			break;
		case 3:
			newsFeed.disasterNews(7);
			break;
		case 4:
			newsFeed.disasterNews(8);
			break;
		case 5:
			newsFeed.disasterNews(9);
			break;
		}

		timer = Random.Range (20,50);
		Debug.Log ("Time before new event: " + timer);
	}
}
