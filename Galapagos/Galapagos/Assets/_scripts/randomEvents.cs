using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class randomEvents : MonoBehaviour {
	public float timer;
	public float timerLimit = 5.0f;

	// Use this for initialization
	void Start () {
		timer = timerLimit;
	}
	
	// Update is called once per frame
	void Update () {
		if(pause.isPaused == false){
			timer -= Time.deltaTime;
			if (timer <= 0.0f) {
				createEvents();
			}
		}
	}

	//Oppretter random event som påvirker spillet enten negativt eller positivt
	public void createEvents(){
		int i = Random.Range (1, 6);

		int j = Random.Range (1, 5);

		switch (i) {
		case 1: //Forsopling rammer en random øy
			newsFeed.disasterNews(5);
			switch(j){
				case 1: if(Stella_kode.ForsoplingFernandina >= 1000){Stella_kode.ForsoplingFernandina += (int)(Stella_kode.ForsoplingFernandina * 0.1);}
				else Stella_kode.ForsoplingFernandina += 5000; 
				break;
				case 2: if(Stella_kode.ForsoplingIsabela >= 1000){Stella_kode.ForsoplingIsabela += (int)(Stella_kode.ForsoplingIsabela * 0.1);}
				else Stella_kode.ForsoplingIsabela += 5000;
				break;
				case 3: if(Stella_kode.ForsoplingSanSalvador >= 1000){Stella_kode.ForsoplingSanSalvador += (int)(Stella_kode.ForsoplingSanSalvador * 0.1);}
				else Stella_kode.ForsoplingSanSalvador += 5000;
				break;
				case 4: if(Stella_kode.ForsoplingSanCristobal >= 1000){Stella_kode.ForsoplingSanCristobal += (int)(Stella_kode.ForsoplingSanSalvador * 0.1);}
				else Stella_kode.ForsoplingSanCristobal += 5000;
				break;
				case 5: if(Stella_kode.ForsoplingSanSalvador >= 1000){Stella_kode.ForsoplingSanSalvador += (int)(Stella_kode.ForsoplingSanSalvador * 0.1);}
				else Stella_kode.ForsoplingSanSalvador += 5000;
				break;
			}
			break;
		case 2: //Det kommer ekstra mange turister neste uke
			newsFeed.disasterNews(6);
			if(Stella_kode.totTurister >= 200){ Stella_kode.eventTourists = (int)(Stella_kode.totTurister * 0.2);}
			else Stella_kode.eventTourists = 200;
			break;
		case 3: //Som følge av oljesøl vil 30% av hver havart dø med en gang
			newsFeed.disasterNews(7);
			Stella_kode.Sjopolse_Fertil = (int)(Stella_kode.Sjopolse_Fertil * 0.85);
			Stella_kode.Sjopolse_Unge = (int)(Stella_kode.Sjopolse_Unge * 0.85);
			Stella_kode.Hai_Fertil = (int)(Stella_kode.Hai_Fertil * 0.85);
			Stella_kode.Hai_Unge = (int)(Stella_kode.Hai_Unge * 0.85);
			break;
		case 4: //Rator Jesus skaper øker populasjon på random øy
			newsFeed.disasterNews(8);
			switch(j){
			case 1: if(Stella_kode.populasjonFernandina >= 100){Stella_kode.populasjonFernandina += (int)(Stella_kode.populasjonFernandina * 0.1);}
				else Stella_kode.populasjonFernandina += 100; 
				break;
			case 2: if(Stella_kode.populasjonIsabela >= 100){Stella_kode.populasjonIsabela += (int)(Stella_kode.populasjonIsabela * 0.1);}
				else Stella_kode.populasjonIsabela += 100;
				break;
			case 3: if(Stella_kode.populasjonSanCristobal >= 100){Stella_kode.populasjonSanCristobal += (int)(Stella_kode.populasjonSanCristobal * 0.1);}
				else Stella_kode.populasjonSanCristobal += 100;
				break;
			case 4: if(Stella_kode.populasjonSanSalvador >= 100){Stella_kode.populasjonSanSalvador += (int)(Stella_kode.populasjonSanSalvador * 0.1);}
				else Stella_kode.populasjonSanSalvador += 100;
				break;
			case 5: if(Stella_kode.populasjonSantaCruz >= 100){Stella_kode.populasjonSantaCruz += (int)(Stella_kode.populasjonSantaCruz * 0.1);}
				else Stella_kode.populasjonSantaCruz += 100;
				break;
			}
			break;
		case 5:
			newsFeed.disasterNews(9);
			break;
		}

		timer = Random.Range (30,50);
	}
}
