using UnityEngine;
using System.Collections;
using System;

public class Stella_kode : MonoBehaviour 
	{
	//Timer
	float timer = 0;
	int uker = 0;
	int forrigeuke = 0;
	int maander = 0;
	int forrigemaande = 0;
	int aar = 0;
	int forrigeaar = 0;
	static float dt = 1;
	
	public int antallSekundermellomUker = 10;

	//Init stocks

	int Politi = 3000;

	int Oppryddere = 3000;
	int Forsopling = 500000;

	int Populasjon = 26000;

	int Hai_Fertil = 10000;
	int Hai_Unge = 10000;

	int Iguana_Fertil = 50000;
	int Iguana_Unge = 50000;

	int Sjopolse_Fertil = 10000000;
	int Sjopolse_Unge = 20000000;

	int Tyvfiskere_Hai = 0;
	int Tyvfiskere_Sjopolse = 0;

	int turister = 0;

	public int okonomi = 0;

	//Variabler

	int Flytter_pga_jobb = 0;
	int Fisking = 780;
	int Antall_jobber = 0;
	float Forsopling_fordelt= 0;
	int Soppel_fra_mennesker = 0;
	int Informerte_Hai = 0;
	int Informerte_om_sjopolse = 0;

	int Hai_Reklame = 0;
	int Iguana_Reklame = 0;
	int Sjopolse_Reklame = 0;
	
	int Kan_ansette_opprydder = 0;
	int Kan_ansette_politi = 0;
	int Maa_ansette_nye = 0;
	int Maa_ansette_politi_pga_hai= 0;
	int Maa_ansette_politi_pga_sjopolse = 0;

	int Tilgjengelig_BP_plass = 0;
	int Tilgjengelig_Fisk_plass = 0;
	int Tilgjengelig_Hai_plass = 0;
	int Tilgjengelig_Iguana_plass = 0;
	int Tilgjengelig_Sjopolse_plass = 0;
	int Turisme = 0;

	int Plass_BP_trenger = 0;
	int Plass_fisk_trenger = 0;
	int Plass_hai_trenger = 0;
	int Plass_iguana_trenger = 0;
	int Plass_sjopolse_trenger = 0;

	int penger_fra_turister_og_innbyggere = 0;
	int Kommunal = 0;
	int Reklame = 0;

	//Brown Pelican voksen ting
	int Brown_Pelican_Fertil = 20000;

	//Brown Pelican ung ting
	int Brown_Pelican_Unge = 30000;

	//Fått_Sparken ting. Altså den som teller hvor mange som har fått sparken
	int Faatt_Sparken = 0;
	int Faatt_Sparken_lite_soppel = 0;

	//FertilFiskting
	int Fertil_Fisk = 25000000;

	int Yngel = 5000000;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Forandrer variabler

		Plass_fisk_trenger = (Yngel / 10000) + (Fertil_Fisk / 10000);
		Plass_BP_trenger = (Brown_Pelican_Fertil / 2) + (Brown_Pelican_Unge / 2);
		Plass_hai_trenger = Hai_Unge + Hai_Fertil;
		Plass_iguana_trenger = (Iguana_Unge / 10) + (Iguana_Fertil / 10);
		Plass_sjopolse_trenger = (Sjopolse_Unge / 1000) + (Sjopolse_Fertil / 1000);

		Hai_Reklame = (int)Math.Floor(Hai_Fertil * 0.01 + Hai_Unge * 0.01);
		Iguana_Reklame = (int)Math.Ceiling((Iguana_Fertil * 0.01) + (Iguana_Unge * 0.01));
		Sjopolse_Reklame = (int)Math.Ceiling ((Sjopolse_Unge + Sjopolse_Fertil) / 0.00000001);
		Reklame = (int)Math.Ceiling((turister * 0.1) + Hai_Reklame + Iguana_Reklame);
		
		penger_fra_turister_og_innbyggere = turister * 150 + Populasjon * 50;
		Kommunal = 9880 + Politi + Oppryddere;
		Informerte_om_sjopolse = (int)Math.Ceiling(Sjopolse_Reklame * 0.01);
		Informerte_Hai = (int)Math.Ceiling(Hai_Reklame * 0.1);
		Forsopling_fordelt = Forsopling / 1000;
		Soppel_fra_mennesker = (int)((turister + Populasjon) / 60);
		Turisme = turister * 2;
		Antall_jobber = Turisme+Fisking+Kommunal;

		Tilgjengelig_BP_plass = (int)Math.Ceiling ((8000 * 2) - (Forsopling_fordelt * 0.09));
		Tilgjengelig_Fisk_plass = (int)(90000000-Forsopling_fordelt);
		Tilgjengelig_Hai_plass = (int)(90000000-Forsopling_fordelt);
		Tilgjengelig_Iguana_plass = (int)Math.Ceiling((8000*10)-(Forsopling_fordelt*0.09));
		Tilgjengelig_Sjopolse_plass = (int)Math.Ceiling (4500000 - Forsopling_fordelt);

		//Timer
		timer += Time.deltaTime;
		uker = (int)Math.Floor(timer / antallSekundermellomUker);
		maander = (int)(uker / 4);
		aar = (int)(maander / 12);

		Debug.Log (uker);

		oppdatererAntall_jobber (Antall_jobber);
		Kan_ansette_opprydder = sjekkomAnsettesOppryddere (okonomi);
		Kan_ansette_politi = sjekkomAnsettesPoliti (okonomi);
		Maa_ansette_nye = sjekkOmAnsettOpprydder(Forsopling, Oppryddere);
		Maa_ansette_politi_pga_hai = sjekkOmAnsettPolitipgaTyvfiskere (Politi, Tyvfiskere_Hai);
		Maa_ansette_politi_pga_sjopolse = sjekkOmAnsettPolitipgaTyvfiskere (Politi, Tyvfiskere_Sjopolse);

		Brown_Pelican_Fertil = updatePelican (Brown_Pelican_Fertil);
		Brown_Pelican_Unge = updatePelicanUnge (Brown_Pelican_Unge);
		Faatt_Sparken = sparkerPgaPenger (Faatt_Sparken);
		Faatt_Sparken_lite_soppel = sparkerPgaLiteForsopling (Faatt_Sparken_lite_soppel);
		Fertil_Fisk = updateFertilFisk (Fertil_Fisk);
		Forsopling = updateForsopling (Forsopling);


		forrigeuke = uker;
		forrigemaande = maander;
	}

	int oppdatererAntall_jobber(int Aj)
	{
		if (Aj > Populasjon) 
		{
			Aj -= Populasjon;
		}

		return (Aj); 
	}

	int sjekkomAnsettesOppryddere (int okonomi)
	{
		if (okonomi > 50 * 300) 
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}

	int sjekkomAnsettesPoliti (int okonomi)
	{
		if (okonomi > 30 * 700) 
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}

	int sjekkOmAnsettOpprydder (int forsopling, int oppryddere)
	{
		if (forsopling >= oppryddere * 500) 
		{
			return 1;
		} 
		else 
		{
			return 0;
		}
	}

	int sjekkOmAnsettPolitipgaTyvfiskere(int politi, int tyvfiskere)
	{
		if (politi * 3 < tyvfiskere) 
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}

	int updatePelican(int fertilBrownPelican)
	{
		//Lager en teller for å holde styr på når BP skal vokse opp. 
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		int BPvokseropp = 0;
		int BPFdorAlderdom = 0;
		int BPFdorForsopling = 0;
		double teller = maander-(aar*12);

		if (maander > forrigemaande) {
			if (teller == 1) {
				BPvokseropp = Brown_Pelican_Unge / 4;

			} else if (teller == 11) {
				BPFdorAlderdom = fertilBrownPelican / 11;
			}
		} 

		if (Plass_BP_trenger > Tilgjengelig_BP_plass) 
		{
			BPFdorForsopling = (int)Math.Floor (fertilBrownPelican * 0.3);
		} 


		fertilBrownPelican = fertilBrownPelican + (BPvokseropp - BPFdorAlderdom - BPFdorForsopling);

		return (fertilBrownPelican);
	}

	int updatePelicanUnge (int ungBrownPelican)
	{
		//Teller gjor det samme som over
		int pelicanKlekkes = 0;
		int BPvokseropp = 0;
		int BPdorforsopling= 0;
		double teller = maander - (aar * 12);

		if (maander > forrigemaande) {
			if (teller == 1) {
				pelicanKlekkes = (int)(Brown_Pelican_Fertil / 2) * 3;
				BPvokseropp = (int)Brown_Pelican_Unge / 4;
			}
		} 

		if (Plass_BP_trenger > Tilgjengelig_BP_plass) 
		{
			BPdorforsopling = (int)Math.Floor(Brown_Pelican_Unge * 0.3);
		} 


		ungBrownPelican = ungBrownPelican+(pelicanKlekkes-BPvokseropp-BPdorforsopling);
		return ungBrownPelican;
	}

	int sparkerPgaPenger (int faat_Sparken)
	{
		//Trenger ingen teller her fordi ingen PULSE som INFLOW eller OUTFLOW
		int ikkeNokPenger;
		if (okonomi <= Oppryddere * 300) 
		{
			ikkeNokPenger = 50;
		} 
		else 
		{
			ikkeNokPenger = 0;
		}

		faat_Sparken = faat_Sparken + ikkeNokPenger;
		return (faat_Sparken);
	}

	int sparkerPgaLiteForsopling(int faarSparkenLiteSoppel)
	{
		int faarSparken;
		if (Forsopling < Oppryddere * 500) 
		{
			faarSparken = 1;
		} 
		else 
		{
			faarSparken = 0;
		}

		faarSparkenLiteSoppel = faarSparkenLiteSoppel + faarSparken;
		return (faarSparkenLiteSoppel);
	}
		
	int updateFertilFisk(int totFFisk)
	{
		int fiskVokserOpp = 0;
		int FiskblirGammel = 0;
		int dorAvAlderdom = 0;
		int dorPgaForsopling = 0;
		int spistFugl = Brown_Pelican_Fertil*30;
		int spistHai = (Hai_Fertil*15)+(Hai_Unge*15);

		double teller = maander - (aar * 12);

		if (maander > forrigemaande) 
		{
			if (teller == 1) {
				fiskVokserOpp = (int)Yngel / 4;
				FiskblirGammel = totFFisk / 11;
			}
		}

		if (Plass_fisk_trenger > Tilgjengelig_Fisk_plass) 
		{
			dorPgaForsopling = (int)Math.Floor(totFFisk*0.3);
		}

		totFFisk = totFFisk + (fiskVokserOpp - FiskblirGammel - dorAvAlderdom - dorPgaForsopling - spistFugl - spistHai);
		return totFFisk;
	}

	int updateForsopling(int totForsopling)
	{
		int innSoppel = Soppel_fra_mennesker;
		int ryddaSoppel = 0;
		//Har en pulse her, men den skal regnes ut hver måned
		//Trenger derfor ikke noen teller

		if (maander > forrigemaande) 
		{
			ryddaSoppel = Oppryddere*500;
		}

		totForsopling = totForsopling + (innSoppel - ryddaSoppel);
		return totForsopling;
	}

//	int updateHaifertil(int fertilHai)
//	{
//		int Grown_up_shark = 0;
//		int Dod_pga_plass_voksen = 0;
//		int Dor_av_tyvfiske = 0;
//		int Dod_alderdom = 0;
//
//
//
//	}
}
