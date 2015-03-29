using UnityEngine;
using System.Collections;
using System;

public class Stella_kode : MonoBehaviour 
	{
	//Timer delt inn i uker, månder og år
	float timer = 0;
	int uker = 0;
	int forrigeuke = 0;
	int maander = 0;
	int forrigemaande = 0;
	int aar = 0;
	int forrigeaar = 0;
	static float dt = 1;

	//Her stilles det hvor mange sekunder det skal ta mellom hver uke.
	public int antallSekundermellomUker = 10;

	//Initierer de forskjellige stockene fra STELLA

	//Politi og tyvfiskere
	int Politi = 3000;
	int Tyvfiskere_Hai = 0;
	int Tyvfiskere_Sjopolse = 0;

	//Søppel og plukkere
	int Oppryddere = 3000;
	int Forsopling = 500000;
	float Forsopling_fordelt= 0;
	int Soppel_fra_mennesker = 0;

	//Populasjonen på øya og deres ting
	int Populasjon = 26000;
	int Flytter_pga_jobb = 0;
	int Antall_jobber = 0;
	int Kommunal = 0;

	//turisme
	int turister = 0;
	int Turister_kommer = 0;
	int Turister_drar = 0;
	int Turisme = 0;
	int penger_fra_turister_og_innbyggere = 0;

	//Hai
	int Hai_Fertil = 10000;
	int Hai_Unge = 10000;

	//Iguana
	int Iguana_Fertil = 50000;
	int Iguana_Unge = 50000;

	//Sjøpølse
	int Sjopolse_Fertil = 10000000;
	int Sjopolse_Unge = 20000000;

	//Okonomien er gjort public for å kunne eksperementere med i Unity
	public int okonomi = 0;

	//Lovlig fiske
	int Fisking = 780;

	//Interesse rundt ulovlig fiske
	int Informerte_Hai = 0;
	int Informerte_om_sjopolse = 0;

	//Rykte eller reklame som dyrene lager
	int Hai_Reklame = 0;
	int Iguana_Reklame = 0;
	int Sjopolse_Reklame = 0;
	//Reklame tilsammen
	int Reklame = 0;

	//Disse variablene blir brukt til å finne ut om noe er sant, der 1 betyr at påstanden er sann, og 0 at den er usann.
	//For eksempel Kan_ansette_politi = 0 betyr at det ikke kan hyres politi, mens = 1 betyr at det er mulig.
	int Kan_ansette_opprydder = 0;
	int Kan_ansette_politi = 0;
	int Maa_ansette_nye = 0;
	int Maa_ansette_politi_pga_hai= 0;
	int Maa_ansette_politi_pga_sjopolse = 0;

	//I disse varibalene lagres plass i forhold til all dyrene.
	int Tilgjengelig_BP_plass = 0;
	int Tilgjengelig_Fisk_plass = 0;
	int Tilgjengelig_Hai_plass = 0;
	int Tilgjengelig_Iguana_plass = 0;
	int Tilgjengelig_Sjopolse_plass = 0;

	//Plass dyrene trenger for å overleve
	int Plass_BP_trenger = 0;
	int Plass_fisk_trenger = 0;
	int Plass_hai_trenger = 0;
	int Plass_iguana_trenger = 0;
	int Plass_sjopolse_trenger = 0;

	//Brown Pelican voksen ting
	int Brown_Pelican_Fertil = 20000;

	//Brown Pelican ung ting
	int Brown_Pelican_Unge = 30000;

	//Fått_Sparken ting. Altså den som teller hvor mange som har fått sparken
	int Faatt_Sparken = 0;
	int Faatt_Sparken_lite_soppel = 0;

	//Fisketing
	int Fertil_Fisk = 25000000;
	int Yngel = 5000000;
	
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Oppdaterer variabler

		//Oppdaterer plassen hvert enkelt dyr har
		Plass_fisk_trenger = (Yngel / 10000) + (Fertil_Fisk / 10000);
		Plass_BP_trenger = (Brown_Pelican_Fertil / 2) + (Brown_Pelican_Unge / 2);
		Plass_hai_trenger = Hai_Unge + Hai_Fertil;
		Plass_iguana_trenger = (Iguana_Unge / 10) + (Iguana_Fertil / 10);
		Plass_sjopolse_trenger = (Sjopolse_Unge / 1000) + (Sjopolse_Fertil / 1000);

		//Oppdaterer hvor mye rykte dyrene sprer
		Hai_Reklame = (int)Math.Floor(Hai_Fertil * 0.01 + Hai_Unge * 0.01);
		Iguana_Reklame = (int)Math.Ceiling((Iguana_Fertil * 0.01) + (Iguana_Unge * 0.01));
		Sjopolse_Reklame = (int)Math.Ceiling ((Sjopolse_Unge + Sjopolse_Fertil) / 0.00000001);
		Reklame = (int)Math.Ceiling((turister * 0.1) + Hai_Reklame + Iguana_Reklame);

		//Oppdaterer pengene vi får inn
		penger_fra_turister_og_innbyggere = turister * 150 + Populasjon * 50;

		//Oppdaterer antall kommunale ansatte
		Kommunal = 9880 + Politi + Oppryddere;
		//Oppdaterer hvor mange som ahr hørt om hai fisk og sjøpølse fisking
		Informerte_om_sjopolse = (int)Math.Ceiling(Sjopolse_Reklame * 0.01);
		Informerte_Hai = (int)Math.Ceiling(Hai_Reklame * 0.1);
		//Deler søpla på arealet
		Forsopling_fordelt = Forsopling / 1000;
		//Oppdaterer søppel fra mennesker
		Soppel_fra_mennesker = (int)((turister + Populasjon) / 60);
		//Regner ut antall ansatte innfor Turisme
		Turisme = turister * 2;
		//Regner ut antall jobber på øyene
		Antall_jobber = Turisme+Fisking+Kommunal;

		//Regner ut plassen for dyrene å leve på
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

		//Regner ut hvor mange som flytter på grunn av jobb
		//
		Flytter_pga_jobb = oppdatererAntall_jobber (Flytter_pga_jobb);

		// Her sjekkes om alle disse situasjonene stemmer. De returnerer enten 1 eller 0. Disse varibalene blir brukt under i andre oppdateringer
		Kan_ansette_opprydder = sjekkomAnsettesOppryddere (okonomi);
		Kan_ansette_politi = sjekkomAnsettesPoliti (okonomi);
		Maa_ansette_nye = sjekkOmAnsettOpprydder(Forsopling, Oppryddere);
		Maa_ansette_politi_pga_hai = sjekkOmAnsettPolitipgaTyvfiskere (Politi, Tyvfiskere_Hai);
		Maa_ansette_politi_pga_sjopolse = sjekkOmAnsettPolitipgaTyvfiskere (Politi, Tyvfiskere_Sjopolse);

		//Oppdaterer bestanden av pelican
		Brown_Pelican_Fertil = updatePelican (Brown_Pelican_Fertil);
		Brown_Pelican_Unge = updatePelicanUnge (Brown_Pelican_Unge);
		//Sparker de som skal sparkes. Disse variablene bare sjekker hvor mange som har blitt sparket. Den sparker ikke fra oppryddere eller politi. 
		//Det skjer i hver sin respektive funksjon
		Faatt_Sparken = sparkerPgaPenger (Faatt_Sparken);
		Faatt_Sparken_lite_soppel = sparkerPgaLiteForsopling (Faatt_Sparken_lite_soppel);
		//Oppdaterer fiskebestanden
		Fertil_Fisk = updateFertilFisk (Fertil_Fisk);
		Yngel = updateYngel (Yngel);
		//Ser hvor mye søppel folk har lagt igjen
		Forsopling = updateForsopling (Forsopling);
		//Oppdaterer haibestanden
		Hai_Fertil = updateHaifertil (Hai_Fertil);
		Hai_Unge = updateHaiunge (Hai_Unge);
		//Oppdaterer Iguana bestanden
		Iguana_Fertil = updateIguanafertil (Iguana_Fertil);
		Iguana_Unge = updateIguanaunge (Iguana_Unge);
		//Oppdaterer økonomien
		okonomi = updateOkonomi (okonomi);
		//Hyrer eller sparker oppryddere
		Oppryddere = updateOppryddere (Oppryddere);
		//Hyrer eller sparker politi
		Politi = updatePoliti (Politi);
		//Oppdaterer populasjonen etter endringen som har skjedd
		Populasjon = updatePopulasjon (Populasjon);
		//Oppdaterer sjøpølse bestanden
		Sjopolse_Fertil = updateSjopolsefertil (Sjopolse_Fertil);
		Sjopolse_Unge = updateSjopolseung (Sjopolse_Unge);
		//Oppdaterer Tyvfiskerne
		Tyvfiskere_Hai = updateTyvfiskereHai (Tyvfiskere_Hai);
		Tyvfiskere_Sjopolse = updateTyvfiskereSjopolse (Tyvfiskere_Sjopolse);

		//Turist conveyer
		//I månedskiftet drar de turistene som kom for en måned siden, mens nye turister kommer.

		if (maander > forrigemaande) 
		{
			Turister_drar = Turister_kommer;
			Turister_kommer = Reklame;
			turister = turister + (Turister_kommer - Turister_drar);
		}

		//I tilfelle det blir månedskifte settes disse lik hverandre
		forrigeuke = uker;
		forrigemaande = maander;
	}
	
	int oppdatererAntall_jobber(int Aj)
	{
		//Her finner vi ut hvor mange som må flytte hit for å fylle opp resten av jobbene
		if (Aj > Populasjon) 
		{
			Aj -= Populasjon;
		}

		return (Aj); 
	}

	int sjekkomAnsettesOppryddere (int okonomi)
	{
		//Her sjekkes det om vi har økonomi til å hyre oppryddere
		// 50 er antallet vi hyrer om gangen og 300 er lønnen deres
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
		//Her sjekkes det om vi kan hyre politi
		//30 er antallet som hyres om gangen og 700 er lønnen
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
		//Her sjekkes det om det er nødvendig å hyre oppryddere
		//ALtså om det er mer søppel enn de opprydderene vi har kan klare
		//500 her er hvor mye søppel i kilo en person klarer å rydde i måneden.
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
		//Her sjekkes det om det er flere tyvfiskere enn det politiet klarer å fange
		//3 her er hvor mange tyvfiskere en politimann klare å fange i måneden
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
		//Lager variablene som vi trenger for å regne ut hvor mange fertile pelikaner det er
		int BPvokseropp = 0;
		int BPFdorAlderdom = 0;
		int BPFdorForsopling = 0;
		//Lager en teller for å holde styr på når BP skal vokse opp. 
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander-(aar*12);

		//Hvis det er månedskifte så sjekker den om vi er i spessielle måneder
		if (maander > forrigemaande) {
			if (teller == 1) {
				//Som i denne måneden vokser ungene opp til voksne
				BPvokseropp = Brown_Pelican_Unge / 4;

			} else if (teller == 11) {
				//Og her så dør noen av alderdom
				BPFdorAlderdom = fertilBrownPelican / 11;
			}
		} 

		if (Plass_BP_trenger > Tilgjengelig_BP_plass) 
		{
			//Dette skjer hvis det er for lite plass for policanen
			//Da dør 30%(0.3) av pelikanene
			//(int) er for å konvertere til int fra hva slags annet tall det ville være
			//Math.Floor runder tallet ned
			BPFdorForsopling = (int)Math.Floor (fertilBrownPelican * 0.3);
		} 

		//Regner sammen både innput og output
		fertilBrownPelican = fertilBrownPelican + (BPvokseropp - BPFdorAlderdom - BPFdorForsopling);
		return (fertilBrownPelican);
	}

	int updatePelicanUnge (int ungBrownPelican)
	{
		int pelicanKlekkes = 0;
		int BPvokseropp = 0;
		int BPdorforsopling= 0;
		
				//Lager en teller for å holde styr på månedene 
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);

		
		if (maander > forrigemaande) 
		{
			if (teller == 1) 
			{
				//  I denne måneden så klekkes og vokser opp barnepelikanene
				pelicanKlekkes = (int)(Brown_Pelican_Fertil / 2) * 3;
				BPvokseropp = (int)Brown_Pelican_Unge / 4;
			}
		} 

		if (Plass_BP_trenger > Tilgjengelig_BP_plass) 
		{
			//Dette skjer hvis det er for lite plass for policanen
			//Da dør 30%(0.3) av pelikanene
			//(int) er for å konvertere til int fra hva slags annet tall det ville være
			//Math.Floor runder tallet ned
			BPdorforsopling = (int)Math.Floor(Brown_Pelican_Unge * 0.3);
		} 

		//Regner sammen både innput og output
		ungBrownPelican = ungBrownPelican+(pelicanKlekkes-BPvokseropp-BPdorforsopling);
		return ungBrownPelican;
	}

	int sparkerPgaPenger (int faat_Sparken)
	{
		//Trenger ingen teller her fordi ingen PULSE som INFLOW eller OUTFLOW
		//Denne her regner ut hvor mange som blir sparket.
		//Den sparker ikke oppryddere akkurat her, men den teller opp hvor mange som vil bli sparket lenger nede

		int ikkeNokPenger;
		//300 er lønna til oppryderne
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
		//Trenger ingen teller her fordi ingen PULSE som INFLOW eller OUTFLOW
		//Denne her regner ut hvor mange som blir sparket.
		//Den sparker ikke oppryddere akkurat her, men den teller opp hvor mange som vil bli sparket lenger nede

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
		//Lager Variablene som er innput og output for fertilFisk
		int fiskVokserOpp = 0;
		int FiskblirGammel = 0;
		int dorAvAlderdom = 0;
		int dorPgaForsopling = 0;
		int spistFugl = Brown_Pelican_Fertil*30;
		int spistHai = (Hai_Fertil*15)+(Hai_Unge*15);
				//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);

		if (maander > forrigemaande) 
		{
			if (teller == 1) {
				//I månede 1 vokser yngel opp og fisk dør av alderdom
				fiskVokserOpp = (int)Yngel / 4;
				FiskblirGammel = totFFisk / 11;
			}
		}

		if (Plass_fisk_trenger > Tilgjengelig_Fisk_plass) 
		{
			//Dette skjer hvis det er for lite plass for fisken
			//Da dør 30%(0.3) av fiskene
			//(int) er for å konvertere til int fra hva slags annet tall det ville være
			//Math.Floor runder tallet ned
			dorPgaForsopling = (int)Math.Floor(totFFisk*0.3);
		}
		
		//Regner sammen antall fisk
		totFFisk = totFFisk + (fiskVokserOpp - FiskblirGammel - dorAvAlderdom - dorPgaForsopling - spistFugl - spistHai);
		return totFFisk;
	}

	int updateForsopling(int totForsopling)
	{
		//Oppdaterer forsøplinga
		//Input og oputput variabler
		int innSoppel = Soppel_fra_mennesker;
		int ryddaSoppel = 0;
		//Har en pulse her, men den skal regnes ut hver måned
		//Trenger derfor ikke noen teller

		if (maander > forrigemaande) 
		{
			//I månedsskiftet kaster vi søppel
			ryddaSoppel = Oppryddere*500;
		}

		totForsopling = totForsopling + (innSoppel - ryddaSoppel);
		return totForsopling;
	}

	int updateHaifertil(int fertilHai)
	{
		//Variabler som er input og output for å regne ut haibestanden
		int Grown_up_shark = 0;
		int Dod_pga_plass_voksen = 0;
		int Dor_av_tyvfiske = Tyvfiskere_Hai*25;
		int Dod_alderdom = 0;

		double teller = maander - (aar * 12);

		if (maander > forrigemaande) 
		{
			if (teller == 1)
			{
				//I første måned så vokser hai opp
				Grown_up_shark = Hai_Unge/10;
			}

			if (teller == 2)
			{
				//Og dør av alderdom
				Dod_alderdom = fertilHai/14;
			}
		}

		if (Plass_hai_trenger > Tilgjengelig_Hai_plass)
		{
			//Som tidligere dør haien når det ikke er plass igjen for den
			// I dette tilfeller dør 10 %
			Dod_pga_plass_voksen = (int)Math.Floor(fertilHai*0.1);
		}

		fertilHai = fertilHai+(Grown_up_shark-Dod_pga_plass_voksen-Dor_av_tyvfiske-Dod_alderdom);
		return fertilHai;
	}

	int updateHaiunge(int ungHai)
	{
		//Variabler for input of output 
		int Hai_fodt = 0;
		int Grown_up_shark = 0;
		int dod_pga_plass = 0;
		int dor_av_tyvfiske_unge = Tyvfiskere_Hai*25;
				//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);

		if (maander > forrigemaande) 
		{
			if (teller == 12)
			{
				//Hai blir født i denne måneden
				Hai_fodt = Hai_Fertil*2;
			}
			else if (teller == 1)
			{
				//Hai vokser opp i denne måneden
				Grown_up_shark = ungHai/10;
			}
		}

		if (Plass_hai_trenger > Tilgjengelig_Hai_plass)
		{
			//Som før, dyr dør når de ikke har plass
			//her dør 10 %
			dod_pga_plass = (int)Math.Floor(ungHai*0.1);
		}

		ungHai = ungHai + (Hai_fodt - Grown_up_shark - dod_pga_plass - dor_av_tyvfiske_unge);
		return ungHai;
	}

	int updateIguanafertil(int fertilIguana)
	{
		//Variabler for input og POutput
		int Iguana_blir_voksen = 0;
		int Dor_av_forsopling_iguana_fertil = 0;
		int Dor_av_alderdom_Iguana = 0;
		//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);
		
		if (maander > forrigemaande) 
		{
			if (teller == 1)
			{
				//iguana vokser opp
				Iguana_blir_voksen = Iguana_Unge/5;
			}
			else if (teller == 12)
			{
				//Iguana dør av alderdom
				Dor_av_alderdom_Iguana = Iguana_Fertil/8;
			}
		}

		if (Plass_iguana_trenger > Tilgjengelig_Iguana_plass) 
		{
			//Dør på grunn av liten plass
			Dor_av_forsopling_iguana_fertil= (int)Math.Floor(fertilIguana* 0.2);
		}

		fertilIguana = fertilIguana + (Iguana_blir_voksen-Dor_av_forsopling_iguana_fertil- Dor_av_alderdom_Iguana);
		return fertilIguana;
	}

	int updateIguanaunge (int ungeIguana)
	{
		//Variabler for input og output 
		int Iguana_fodt = 0;
		int Iguana_blir_voksen = 0;
		int Dor_av_forsopling_iguana_Unge = 0;
		//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);
		
		if (maander > forrigemaande) 
		{
			if (teller == 1)
			{
				//Iguana vokser opp
				Iguana_blir_voksen = Iguana_Unge/5;
			}
			else if (teller == 4)
			{
				//Iguana blirn født
				Iguana_fodt = Iguana_Fertil*2;
			}
		}

		if (Plass_iguana_trenger > Tilgjengelig_Iguana_plass) 
		{
			//Lite plass, mindre iguana
			Dor_av_forsopling_iguana_Unge = (int)Math.Floor (Iguana_Unge*0.2);
		}

		ungeIguana = ungeIguana + (Iguana_fodt - Iguana_blir_voksen - Dor_av_forsopling_iguana_Unge);
		return ungeIguana;
	}

	int updateOkonomi(int totOkonomi)
	{
		//Variabler for input og output
		int Inntekter = 0;
		int sparing = (int)Math.Floor (totOkonomi*0.3);
		int Penger_politi = Politi*700;
		int Penger_Oppryddere = Oppryddere*300;
		//Trenger ikke teller fordi dette skal skje hver måned
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		if (maander > forrigemaande) 
		{
			//Tar penger fra turister og innbyggere
			//Stjeler litt fra dyrene også med det snakker vi ikke om
			Inntekter = penger_fra_turister_og_innbyggere;
		}

		totOkonomi = totOkonomi + (Inntekter - sparing - Penger_politi - Penger_Oppryddere);
		return totOkonomi;
	}

	int updateOppryddere (int totOppryddere)
	{
		//Variabler: Input og ouput
		int ansette_nye = 0;
		int Sparken = 0;
		int Sparken_ikke_mer_penger = 0;

		if (Maa_ansette_nye + Kan_ansette_opprydder == 2) 
		{
			//Ansettes ny oppryddere fordi vi kan og må (maa)
			ansette_nye=50;
		}

		if (Forsopling <= totOppryddere * 500) 
		{
			//Sparkes fordi de ikke trengs
			Sparken = 1;
		}

		if (okonomi <= totOppryddere * 300) 
		{
			//Har ikke nok penger til å betale folk
			Sparken_ikke_mer_penger = 50;
		}

		totOppryddere = totOppryddere+(ansette_nye-Sparken-Sparken_ikke_mer_penger);
		return totOppryddere;
	}

	int updatePoliti (int totPoliti)
	{
		//Variabler med input og output
		int Politi_ansettes_pga_hai = 0;
		int Politi_ansettes_pga_Sjopolse = 0;
		int Politi_sparkes_ingen_tyver = 0;
		int Politi_sparkes_lite_penger = 0;

		if (Maa_ansette_politi_pga_hai + Kan_ansette_politi == 2) 
		{
			//Her ansettes det hvis man må (pga hai) og kan (nok penger)
			Politi_ansettes_pga_hai = 50;
		}

		if (Maa_ansette_politi_pga_sjopolse + Kan_ansette_politi == 2) 
		{
			//Her ansettes det hvis man må (pga sjøpølse) og kan (nok penger)
			Politi_ansettes_pga_Sjopolse = 50;
		}

		if (Tyvfiskere_Hai < Politi / 3) 
		{
			//Nedkutting hos politiet
			Politi_sparkes_ingen_tyver = 5;
		}

		if (okonomi <= totPoliti * 700) 
		{
			//Her sparker de bare fordi de ikke har råd
			Politi_sparkes_lite_penger = 50;
		}

		totPoliti = totPoliti + (Politi_ansettes_pga_hai + Maa_ansette_politi_pga_sjopolse - Politi_sparkes_ingen_tyver - Politi_sparkes_lite_penger);
		return totPoliti;
	}

	int updatePopulasjon (int totPopulasjon)
	{
		//Variabler input og output
		int Folk_inn = Flytter_pga_jobb;
		int Folk_flytter = 0;

		if (Antall_jobber < Populasjon) 
		{
			//Regner ut folk som flytter pga lite jobber
			Folk_flytter = Populasjon-Antall_jobber;
		}

		totPopulasjon = totPopulasjon + (Folk_inn - Folk_flytter);
		return totPopulasjon;
	}

	int updateSjopolsefertil (int fertilSjopolse)
	{
		//Variabler input og output
		int Sjopolse_blir_voksen = 0;
		int Dor_av_forsopling_sjopolse_Fertil = 0;
		int Dor_av_alderdom_sjopolse = 0;
		int lovlig_fiske_F = (int)Math.Floor(Sjopolse_Fertil * 0.1);
		int Ulovlig_fiske_F = Tyvfiskere_Sjopolse * 1000;
				//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);
		
		if (maander > forrigemaande) 
		{
			if (teller == 1)
			{
				//Sjøpølse vokser opp
				Sjopolse_blir_voksen = (int)Sjopolse_Unge/4;
			}
			else if (teller == 8)
			{
				//Sjøpølse dør fordi den er gammel
				Dor_av_alderdom_sjopolse = Sjopolse_Fertil/5;
			}
		}

		fertilSjopolse = fertilSjopolse + (Sjopolse_blir_voksen - Dor_av_forsopling_sjopolse_Fertil - Dor_av_alderdom_sjopolse - lovlig_fiske_F - Ulovlig_fiske_F);
		return fertilSjopolse;
	}

	int updateSjopolseung ( int ungSjopolse)
	{
		//Variabler input og output
		int Sjopolse_klekkes = 0;
		int Sjopolse_blir_voksen = 0;
		int Dor_av_forsopling_sjopolse_unge = 0;
		int lovlig_fiske_U = (int)Math.Floor (ungSjopolse * 0.1);
		int Ulovlig_fiske_U = Tyvfiskere_Sjopolse * 1000;
				//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);

		if (maander > forrigemaande) 
		{
			if (teller == 1)
			{
				//Sjøpølse vokser opp
				Sjopolse_blir_voksen = (int)ungSjopolse/4;
			}
			else if (teller == 12)
			{
				if (Plass_sjopolse_trenger < Tilgjengelig_Sjopolse_plass)
				{
					//Hvis det er plass, så fødes det flere sjøpølser
					Sjopolse_klekkes = Sjopolse_Fertil/2*10000;
				}
			}
		}

		if (Plass_sjopolse_trenger > Tilgjengelig_Sjopolse_plass) 
		{
			//Lite plass, mindre sjøpølser
			Dor_av_forsopling_sjopolse_unge = (int)Math.Floor(Sjopolse_Unge * 0.2);
		}

		ungSjopolse = ungSjopolse + (Sjopolse_klekkes - Sjopolse_blir_voksen - Dor_av_forsopling_sjopolse_unge - lovlig_fiske_U - Ulovlig_fiske_U);
		return ungSjopolse;
	}

	int updateTyvfiskereHai(int totTyvfiskereHai)
	{
		//Variabler input og outpout
		int Tyvfiskere_Hai_kommer = Informerte_Hai;
		int haifiskere_fanget = Politi * 3;
		int Tyvfiskere_hai_slutter = 0;
		//Hvis haien går under 3000 så stopper mange å fiske
		if (Hai_Fertil < 3000) 
		{
			Tyvfiskere_hai_slutter = (int)Math.Floor(totTyvfiskereHai*0.3);
		}

		totTyvfiskereHai = totTyvfiskereHai + (Tyvfiskere_Hai_kommer - haifiskere_fanget - Tyvfiskere_hai_slutter);
		return totTyvfiskereHai;
	}

	int updateTyvfiskereSjopolse (int totTyvfiskereSjopolse)
	{
		//Variablene input og output
		int Tyvfiskere_sjopolse_kommer = Informerte_om_sjopolse;
		int sjopolsefiskere_fanget = Politi * 3;
		int Tyvfiske_sjopolse_slutter = 0;
		
		if (Sjopolse_Fertil < 1000000000) 			//9 nuller
		{ 
			//Tyvfiskere stopper å fiske med for lite sjøpølse
			Tyvfiske_sjopolse_slutter = (int)Math.Floor (totTyvfiskereSjopolse*0.3);
		}

		totTyvfiskereSjopolse = totTyvfiskereSjopolse + (Tyvfiskere_sjopolse_kommer - sjopolsefiskere_fanget - Tyvfiske_sjopolse_slutter);
		return totTyvfiskereSjopolse;
	}

	int updateYngel (int totYngel)
	{	
		//variabler input og output
		int Fisk_klekkes = 0;
		int fisk_blir_voksen = 0;
		int Dor_pga_forsopling_Fisk_Y = 0;

				//Lager en teller for å holde styr på månedene
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander - (aar * 12);
		
		if (maander > forrigemaande) 
		{
			if (teller == 1)
			{
				//Fisk blir født og vokser opp
				Fisk_klekkes = (Fertil_Fisk/2)*1000;
				fisk_blir_voksen = (int) (Yngel/4);
			}
		}

		if (Plass_fisk_trenger > Tilgjengelig_Fisk_plass) 
		{
			//Fisk dør pga liten plass
			Dor_pga_forsopling_Fisk_Y = (int)Math.Floor(Yngel*0.3);
		}

		totYngel = totYngel + (Fisk_klekkes - fisk_blir_voksen - Dor_pga_forsopling_Fisk_Y);
		return totYngel;
	}
}
