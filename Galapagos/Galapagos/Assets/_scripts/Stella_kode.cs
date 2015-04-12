using UnityEngine;
using System.Collections;
using System;

public class Stella_kode : MonoBehaviour
{
	//Timer delt inn i uker, månder og år
	public static float timer = 0;
	int uker = 0;
	int forrigeuke = 0;
	int maander = 0;
	int forrigemaande = 0;
	int aar = 0;
	//int forrigeaar = 0;

	//Her stilles det hvor mange sekunder det skal ta mellom hver uke.
	public int antallSekundermellomUker = 5;
	
	//Initierer de forskjellige stockene fra STELLA
	
	//Areal fra Øyene
	public static int arealFernadina = 624; //km2
	public static int arealIsabela = 4640;
	public static int arealSanCristobal = 558;
	public static int arealSanSalvador = 585;
	public static int arealSantaCruz = 986;
	
	public static float prosentFernadina = 0;
	public static float prosentIsabela = 0;
	public static float prosentSanCristobal = 0;
	public static float prosentSanSalvador = 0;
	public static float prosentSantaCruz = 0;
	
	//Politi og tyvfiskere
	public static int Politi;
	public static int Tyvfiskere_Hai = 0;
	public static int Tyvfiskere_Sjopolse = 0;
	
	//Søppel og plukkere
	public static int oppryddereFernandina = 0;
	public static int oppryddereIsabela = 0;
	public static int oppryddereSanCristobal = 0;
	public static int oppryddereSanSalvador = 0;
	public static int oppryddereSantaCruz = 0;
	public static int oppryddereHav = 0;
	public static int totAntallOppryddere = 0;
	
	public static int ForsoplingFernandina;
	public static int ForsoplingIsabela;
	public static int ForsoplingSanCristobal;
	public static int ForsoplingSanSalvador;
	public static int ForsoplingSantaCruz;
	int ForsoplingHav = 0;
	//int totAntallForsopling = 0;
	
	
	float Forsopling_fordeltFernandina = 0;
	float Forsopling_fordeltIsabela = 0;
	float Forsopling_fordeltSanCristobal = 0;
	float Forsopling_fordeltSanSalvador = 0;
	float Forsopling_fordeltSantaCruz = 0;
	float Forsopling_fordeltHav = 0;
	
	int totSoppel_fra_mennesker = 0;
	
	//Populasjonen på øya og deres ting
	int totPopulasjon = 100;
	int movingIn;
	public static int populasjonFernandina = 10;
	public static int populasjonIsabela = 10;
	public static int populasjonSanCristobal = 10;
	public static int populasjonSanSalvador = 10;
	public static int populasjonSantaCruz = 10;
	
	int Flytter_pga_jobb = 0;
	int Antall_jobber = 0;
	int Kommunal = 0;
	
	//turisme
	public static int turisterFernandina = 0;
	public static int turisterIsabela = 0;
	public static int turisterSanCristobal = 0;
	public static int turisterSanSalvador = 0;
	public static int turisterSantaCruz = 0;
	int totTurister = 100;
	int Turister_kommer = 0;
	int Turister_drar = 0;
	int Turisme = 0;
	int penger_fra_turister_og_innbyggere = 0;
	
	//Hai
	int Hai_Fertil = 5000;
	int Hai_Unge = 30000;
	
	//Iguana
	int Iguana_Fertil = 20000;
	int Iguana_Unge = 80000;
	
	//Sjøpølse
	int Sjopolse_Fertil = 1000000;
	int Sjopolse_Unge = 2000000;
	
	//Okonomien er gjort public for å kunne eksperementere med i Unity
	public static int okonomi = 1000;
	
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
	
	//I disse varibalene lagres plass i forhold til all dyrene.
	int Tilgjengelig_BP_plassFernandia = 0;
	int Tilgjengelig_BP_plassIsabela = 0;
	int Tilgjengelig_BP_plassSanCristobal = 0;
	int Tilgjengelig_BP_plassSanSalvador = 0;
	int Tilgjengelig_BP_plassSantaCruz = 0;
	
	int Tilgjengelig_Fisk_plass = 0;
	int Tilgjengelig_Hai_plass = 0;
	
	int Tilgjengelig_Iguana_plassFernandina = 0;
	int Tilgjengelig_Iguana_plassIsabela = 0;
	int Tilgjengelig_Iguana_plassSanCristobal = 0;
	int Tilgjengelig_Iguana_plassSanSalvador = 0;
	int Tilgjengelig_Iguana_plassSantaCruz = 0;
	
	int Tilgjengelig_Sjopolse_plass = 0;
	
	//Plass dyrene trenger for å overleve
	int Plass_BP_trengerFernadina = 0;
	int Plass_BP_trengerIsabela = 0;
	int Plass_BP_trengerSanCristobal = 0;
	int Plass_BP_trengerSanSalvador = 0;
	int Plass_BP_trengerSantaCruz = 0;
	
	int Plass_fisk_trenger = 0;
	int Plass_hai_trenger = 0;
	
	int Plass_iguana_trengerFernandina = 0;
	int Plass_iguana_trengerIsabela = 0;
	int Plass_iguana_trengerSanCristobal = 0;
	int Plass_iguana_trengerSanSalvador = 0;
	int Plass_iguana_trengerSantaCruz = 0;
	
	int Plass_sjopolse_trenger = 0;
	
	//Brown Pelican voksen ting
	int Brown_Pelican_Fertil = 1000;
	
	//Brown Pelican ung ting
	int Brown_Pelican_Unge = 2000;
	
	//Fisketing
	int Fertil_Fisk = 25000;
	int Yngel = 50000;
	
	int totalAreal;
	
	public static int Brown_Pelican_FertilFernandina;
	public static int Brown_Pelican_FertilIsabela;
	public static int Brown_Pelican_FertilSanCristobal;
	public static int Brown_Pelican_FertilSanSalvador;
	public static int Brown_Pelican_FertilSantaCruz;
	
	public static int Brown_Pelican_UngeFernandina;
	public static int Brown_Pelican_UngeIsabela;
	public static int Brown_Pelican_UngeSanCristobal;
	public static int Brown_Pelican_UngeSanSalvador;
	public static int Brown_Pelican_UngeSantaCruz;
	
	public static int Iguana_FertilFernandina;
	public static int Iguana_FertilIsabela;
	public static int Iguana_FertilSanCristobal;
	public static int Iguana_FertilSanSalvador;
	public static int Iguana_FertilSantaCruz;
	
	public static int Iguana_UngFernandina;
	public static int Iguana_UngIsabela;
	public static int Iguana_UngSanCristobal;
	public static int Iguana_UngSanSalvador;
	public static int Iguana_UngSantaCruz;

	int test = 0;
	
	// Use this for initialization
	void Start ()
	{
		//Henter inn tall fra islandInfo
		oppryddereFernandina = islandInfo.ansatteFernadina;
		oppryddereIsabela = islandInfo.ansatteIsabela;
		oppryddereSanCristobal = islandInfo.ansatteSanCristobal;
		oppryddereSanSalvador = islandInfo.ansatteSanSalvador;
		oppryddereSantaCruz = islandInfo.ansatteSantaCruz;
		Politi = oceanInfo.ansatteOcean;
<<<<<<< HEAD

		prosentFernadina = 8.44f;
		prosentIsabela = 62.76f;
		prosentSanCristobal = 7.55f;
		prosentSanSalvador = 7.91f;
		prosentSantaCruz = 13.34f;
=======
		
		//Regner ut total areal av alle øyene7
		totalAreal = arealFernadina + arealIsabela + arealSanCristobal+arealSanSalvador+arealSantaCruz;
		//Regner ut prosent av arealet av øyene
		prosentFernadina = ((arealFernadina / totalAreal) * 100);
		prosentIsabela = ((arealIsabela / totalAreal) * 100);
		prosentSanCristobal = ((arealSanCristobal / totalAreal) * 100);
		prosentSanSalvador = ((arealSanSalvador / totalAreal) * 100);
		prosentSantaCruz = ((arealSantaCruz / totalAreal) * 100);
		Debug.Log ("Areal: " + prosentFernadina);
>>>>>>> JOhn

		//Har definert hvor mange pelikaner det er over så nå deler jeg det mellom øyene basert på hvor stor øyene er.
		//Gjør det samme med Iguana. Trenger bare å gjøre det med disse to siden de er land dyr.
		Debug.Log ("pelikaner før: " + Brown_Pelican_FertilFernandina);
		Brown_Pelican_FertilFernandina = (int) (prosentFernadina * Brown_Pelican_Fertil / 100);
		Debug.Log ("pelikaner etter: " + Brown_Pelican_FertilFernandina);

		Brown_Pelican_FertilIsabela = (int)(prosentIsabela * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilSanCristobal = (int)(prosentSanCristobal * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilSanSalvador = (int)(prosentSanSalvador * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilSantaCruz = (int)(prosentSantaCruz * Brown_Pelican_Fertil / 100);

		Debug.Log ("Unger Før: " + Brown_Pelican_UngeFernandina);
		Brown_Pelican_UngeFernandina = (int)(prosentFernadina * Brown_Pelican_Unge / 100);
		Debug.Log ("Unger etter: " + Brown_Pelican_UngeFernandina);

		Brown_Pelican_UngeIsabela = (int)(prosentIsabela * Brown_Pelican_Unge / 100);
		Brown_Pelican_UngeSanCristobal = (int)(prosentSanCristobal * Brown_Pelican_Unge / 100);
		Brown_Pelican_UngeSanSalvador = (int)(prosentSanSalvador * Brown_Pelican_Unge / 100);
		Brown_Pelican_UngeSantaCruz = (int)(prosentSantaCruz * Brown_Pelican_Unge / 100);
		
		Iguana_FertilFernandina = (int)(prosentFernadina * Iguana_Fertil / 100);
		Iguana_FertilIsabela = (int)(prosentIsabela * Iguana_Fertil / 100);
		Iguana_FertilSanCristobal = (int)(prosentSanCristobal * Iguana_Fertil / 100);
		Iguana_FertilSanSalvador = (int)(prosentSanSalvador * Iguana_Fertil / 100);
		Iguana_FertilSantaCruz = (int)(prosentSantaCruz * Iguana_Fertil / 100);
		
		Iguana_UngFernandina = (int)(prosentFernadina * Iguana_Unge / 100);
		Iguana_UngIsabela = (int)(prosentIsabela * Iguana_Unge / 100);
		Iguana_UngSanCristobal = (int)(prosentSanCristobal * Iguana_Unge / 100);
		Iguana_UngSanSalvador = (int)(prosentSanSalvador * Iguana_Unge / 100);
		Iguana_UngSantaCruz = (int)(prosentSantaCruz * Iguana_Unge / 100);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Oppdaterer variabler
		
		//Timer
		timer += Time.deltaTime;
		uker = (int)Math.Floor (timer / antallSekundermellomUker);
		maander = (int)(uker / 4);
		aar = (int)(maander / 12);
		
		if (uker > forrigeuke) {
			//Oppdaterer plassen hvert enkelt dyr har
			Plass_fisk_trenger = (Yngel / 10000) + (Fertil_Fisk / 10000);
			
			Plass_BP_trengerFernadina = (Brown_Pelican_FertilFernandina / 2) + (Brown_Pelican_UngeFernandina / 2);
			Plass_BP_trengerIsabela = (Brown_Pelican_FertilIsabela / 2) + (Brown_Pelican_UngeIsabela / 2);
			Plass_BP_trengerSanCristobal = (Brown_Pelican_FertilSanCristobal / 2) + (Brown_Pelican_UngeSanCristobal / 2);
			Plass_BP_trengerSanSalvador = (Brown_Pelican_FertilSanSalvador / 2) + (Brown_Pelican_UngeSanSalvador / 2);
			Plass_BP_trengerSantaCruz = (Brown_Pelican_FertilSantaCruz / 2) + (Brown_Pelican_UngeSantaCruz / 2);
			
			Plass_hai_trenger = Hai_Unge + Hai_Fertil;
			
			Plass_iguana_trengerFernandina = (Iguana_UngFernandina / 10) + (Iguana_FertilFernandina / 10);
			Plass_iguana_trengerIsabela = (Iguana_UngIsabela / 10) + (Iguana_FertilIsabela / 10);
			Plass_iguana_trengerSanCristobal = (Iguana_UngSanCristobal / 10) + (Iguana_UngSanCristobal / 10);
			Plass_iguana_trengerSanSalvador = (Iguana_UngSanSalvador / 10) + (Iguana_FertilSanSalvador / 10);
			
			Plass_sjopolse_trenger = (Sjopolse_Unge / 1000) + (Sjopolse_Fertil / 1000);
			
			//Oppdaterer hvor mye rykte dyrene sprer
			Hai_Reklame = (int)Math.Floor (Hai_Fertil * 0.01 + Hai_Unge * 0.01);
<<<<<<< HEAD
			Iguana_Reklame = (int)Math.Ceiling ((Iguana_Fertil * 0.01) + (Iguana_Unge * 0.001));
			Sjopolse_Reklame = (int)Math.Ceiling ((Sjopolse_Unge + Sjopolse_Fertil) / 0.0000001);
			Sjopolse_Reklame = (int)Math.Ceiling (Sjopolse_Reklame * 0.0000001);
			Reklame = (int)Math.Ceiling ((totTurister * 0.1) + Hai_Reklame + Iguana_Reklame + Sjopolse_Reklame);
=======
			Iguana_Reklame = (int)Math.Ceiling ((Iguana_Fertil * 0.01) + (Iguana_Unge * 0.01));
			Sjopolse_Reklame = (int)Math.Ceiling ((/*Sjopolse_Unge +*/ Sjopolse_Fertil)/ 0.00000001);
			Reklame = (int)Math.Ceiling ((totTurister * 0.1) + Hai_Reklame + Iguana_Reklame);
>>>>>>> JOhn
			
			//Oppdaterer pengene vi får inn
			penger_fra_turister_og_innbyggere = totTurister * 150 + totPopulasjon * 50;
			
			//Oppdaterer hvor mange som ahr hørt om hai fisk og sjøpølse fisking
			Informerte_om_sjopolse = (int)Math.Ceiling (Sjopolse_Reklame * 0.01);
			Informerte_Hai = (int)Math.Ceiling (Hai_Reklame * 0.1);


			//Regner ut plassen for dyrene å leve på
			
			Tilgjengelig_BP_plassFernandia = (int)Math.Ceiling ((arealFernadina * 2) - (Forsopling_fordeltFernandina * 0.09));
			Tilgjengelig_BP_plassIsabela = (int)Math.Ceiling ((arealIsabela * 2) - (Forsopling_fordeltIsabela * 0.09));
			Tilgjengelig_BP_plassSanCristobal = (int)Math.Ceiling ((arealSanCristobal * 2) - (Forsopling_fordeltSanCristobal * 0.09));
			Tilgjengelig_BP_plassSanSalvador = (int)Math.Ceiling ((arealSanSalvador * 2) - (Forsopling_fordeltSanSalvador * 0.09));
			Tilgjengelig_BP_plassSantaCruz = (int)Math.Ceiling ((arealSantaCruz * 2) - (Forsopling_fordeltSantaCruz * 0.09));
			
			Tilgjengelig_Iguana_plassFernandina = (int)Math.Ceiling ((arealFernadina * 10) - (Forsopling_fordeltFernandina * 0.09));
			Tilgjengelig_Iguana_plassIsabela = (int)Math.Ceiling ((arealIsabela * 10) - (Forsopling_fordeltIsabela * 0.09));
			Tilgjengelig_Iguana_plassSanCristobal = (int)Math.Ceiling ((arealSanCristobal * 10) - (Forsopling_fordeltSanCristobal * 0.09));
			Tilgjengelig_Iguana_plassSanSalvador = (int)Math.Ceiling ((arealSanSalvador * 10) - (Forsopling_fordeltSanSalvador * 0.09));
			Tilgjengelig_Iguana_plassSantaCruz = (int)Math.Ceiling ((arealSantaCruz * 10) - (Forsopling_fordeltSantaCruz * 0.09));
			
			Tilgjengelig_Fisk_plass = (int)(90000000 - Forsopling_fordeltHav);
			Tilgjengelig_Hai_plass = (int)(90000000 - Forsopling_fordeltHav);
			Tilgjengelig_Sjopolse_plass = (int)Math.Ceiling (4500000 - Forsopling_fordeltHav);
			
			
			
			Debug.Log (uker);
			
			//Regner ut hvor mange som flytter på grunn av jobb
			//
			Flytter_pga_jobb = oppdatererAntall_jobber (Flytter_pga_jobb);
			

			
			//Oppdaterer bestanden av pelican
			Brown_Pelican_FertilFernandina = updatePelican (Brown_Pelican_FertilFernandina, Brown_Pelican_UngeFernandina, Plass_BP_trengerFernadina, Tilgjengelig_BP_plassFernandia);
			Brown_Pelican_FertilIsabela = updatePelican (Brown_Pelican_FertilIsabela, Brown_Pelican_UngeIsabela, Plass_BP_trengerIsabela, Tilgjengelig_BP_plassIsabela);
			Brown_Pelican_FertilSanCristobal = updatePelican (Brown_Pelican_FertilSanCristobal, Brown_Pelican_UngeSanCristobal, Plass_BP_trengerSanCristobal, Tilgjengelig_BP_plassSanCristobal);
			Brown_Pelican_FertilSanSalvador = updatePelican (Brown_Pelican_FertilSanSalvador, Brown_Pelican_UngeSanSalvador, Plass_BP_trengerSanSalvador, Tilgjengelig_BP_plassSanSalvador);
			Brown_Pelican_FertilSantaCruz = updatePelican (Brown_Pelican_FertilSantaCruz, Brown_Pelican_UngeSantaCruz, Plass_BP_trengerSantaCruz, Tilgjengelig_BP_plassSantaCruz);
			
			Brown_Pelican_UngeFernandina = updatePelicanUnge (Brown_Pelican_FertilFernandina, Brown_Pelican_UngeFernandina, Plass_BP_trengerFernadina, Tilgjengelig_BP_plassFernandia);
			Brown_Pelican_UngeIsabela = updatePelicanUnge (Brown_Pelican_FertilIsabela, Brown_Pelican_UngeIsabela, Plass_BP_trengerIsabela, Tilgjengelig_BP_plassIsabela);
			Brown_Pelican_UngeSanCristobal = updatePelicanUnge (Brown_Pelican_FertilSanCristobal, Brown_Pelican_UngeSanCristobal, Plass_BP_trengerSanCristobal, Tilgjengelig_BP_plassSanCristobal);
			Brown_Pelican_UngeSanSalvador = updatePelicanUnge (Brown_Pelican_FertilSanSalvador, Brown_Pelican_UngeSanSalvador, Plass_BP_trengerSanSalvador, Tilgjengelig_BP_plassSanSalvador);
			Brown_Pelican_UngeSantaCruz = updatePelicanUnge (Brown_Pelican_FertilSantaCruz, Brown_Pelican_UngeSantaCruz, Plass_BP_trengerSantaCruz, Tilgjengelig_BP_plassSantaCruz);
			
			//Oppdaterer fiskebestanden
			Fertil_Fisk = updateFertilFisk (Fertil_Fisk);
			Yngel = updateYngel (Yngel);
			//Ser hvor mye søppel folk har lagt igjen
			ForsoplingFernandina = updateForsopling (ForsoplingFernandina, oppryddereFernandina);
			ForsoplingIsabela = updateForsopling (ForsoplingIsabela, oppryddereIsabela);
			ForsoplingSanCristobal = updateForsopling (ForsoplingSanCristobal, oppryddereSanCristobal);
			ForsoplingSanSalvador = updateForsopling (ForsoplingSantaCruz, oppryddereSantaCruz);
			ForsoplingSantaCruz = updateForsopling (ForsoplingSantaCruz, oppryddereSantaCruz);
			ForsoplingHav = updateForsopling (ForsoplingHav, oppryddereHav);
			
			//Oppdaterer haibestanden
			Hai_Fertil = updateHaifertil (Hai_Fertil);
			Hai_Unge = updateHaiunge (Hai_Unge);
			//Oppdaterer Iguana bestanden
			Iguana_FertilFernandina = updateIguanafertil (Iguana_FertilFernandina, Iguana_UngFernandina, Plass_BP_trengerFernadina, Tilgjengelig_Iguana_plassFernandina);
			Iguana_FertilIsabela = updateIguanafertil (Iguana_FertilIsabela, Iguana_UngIsabela, Plass_BP_trengerIsabela, Tilgjengelig_Iguana_plassIsabela);
			Iguana_FertilSanCristobal = updateIguanafertil (Iguana_FertilSanCristobal, Iguana_UngSanCristobal, Plass_BP_trengerSanCristobal, Tilgjengelig_Iguana_plassSanCristobal);
			Iguana_FertilSanSalvador = updateIguanafertil (Iguana_FertilSanSalvador, Iguana_UngSanSalvador, Plass_BP_trengerSanSalvador, Tilgjengelig_Iguana_plassSanSalvador);
			Iguana_FertilSantaCruz = updateIguanafertil (Iguana_FertilSantaCruz, Iguana_UngSantaCruz, Plass_BP_trengerSantaCruz, Tilgjengelig_Iguana_plassSantaCruz);
			
			Iguana_UngFernandina = updateIguanaunge (Iguana_FertilFernandina, Iguana_UngFernandina, Plass_iguana_trengerFernandina, Tilgjengelig_Iguana_plassFernandina);
			Iguana_UngIsabela = updateIguanaunge (Iguana_FertilIsabela, Iguana_UngIsabela, Plass_iguana_trengerIsabela, Tilgjengelig_Iguana_plassIsabela);
			Iguana_UngSanCristobal = updateIguanaunge (Iguana_FertilSanCristobal, Iguana_UngSanCristobal, Plass_iguana_trengerSanCristobal, Tilgjengelig_Iguana_plassSanCristobal);
			Iguana_UngSanSalvador = updateIguanaunge (Iguana_FertilSanSalvador, Iguana_UngSanSalvador, Plass_iguana_trengerSanSalvador, Tilgjengelig_Iguana_plassSanSalvador);
			Iguana_UngSantaCruz = updateIguanaunge (Iguana_FertilSantaCruz, Iguana_UngSantaCruz, Plass_iguana_trengerSantaCruz, Tilgjengelig_Iguana_plassSantaCruz);
			
			//Oppdaterer økonomien
			okonomi = updateOkonomi (okonomi);
			//Hyrer eller sparker oppryddere

//			//Hyrer eller sparker politi
//			Politi = updatePoliti (Politi);
			//Oppdaterer populasjonen etter endringen som har skjedd
			totPopulasjon = updatePopulasjon (totPopulasjon);

			//Oppdaterer sjøpølse bestanden
			Sjopolse_Fertil = updateSjopolsefertil (Sjopolse_Fertil);
			Sjopolse_Unge = updateSjopolseung (Sjopolse_Unge);
			//Oppdaterer Tyvfiskerne
			Tyvfiskere_Hai = updateTyvfiskereHai (Tyvfiskere_Hai);
			Tyvfiskere_Sjopolse = updateTyvfiskereSjopolse (Tyvfiskere_Sjopolse);

<<<<<<< HEAD

			//Regner ut antall ansatte innfor Turisme
			Turisme = totTurister * 2;
			//Regner ut antall jobber på øyene
			Antall_jobber = Turisme + Fisking + Kommunal;
			//regner ut totalt antall oppryddere
			totAntallOppryddere = oppryddereFernandina + oppryddereIsabela + oppryddereSanCristobal + oppryddereSanSalvador + oppryddereSantaCruz + oppryddereHav;
			//Regner ut totalt søppel
			//totAntallForsopling = ForsoplingFernandina + ForsoplingIsabela + ForsoplingSanCristobal + ForsoplingSanSalvador + ForsoplingSantaCruz + ForsoplingHav;
			//Oppdaterer antall kommunale ansatte
			Kommunal = 9880 + Politi + totAntallOppryddere;
			
=======
>>>>>>> JOhn
			//Turist conveyer
			//I månedskiftet drar de turistene som kom for en måned siden, mens nye turister kommer.
			
			//if (maander > forrigemaande) {
			Turister_drar = totTurister;
			movingIn = (int)Math.Floor (totTurister * 0.1);
			Debug.Log ("Moving in: " + movingIn);
			totPopulasjon = totPopulasjon + movingIn;
			Debug.Log("tot populasjon: " + totPopulasjon);
			Turister_kommer = Reklame;
			Debug.Log("Fernandina populasjon: " + populasjonFernandina);
			populasjonFernandina = (int)(prosentFernadina * totPopulasjon) / 100;
			Debug.Log ("populasjon fernandina: " + populasjonFernandina); 
			populasjonIsabela = (int)(prosentIsabela * totPopulasjon) / 100;
			populasjonSanCristobal = (int)(prosentSanCristobal * totPopulasjon) / 100;
			populasjonSanSalvador = (int)(prosentSanSalvador * totPopulasjon) / 100;
			populasjonSantaCruz = (int)(prosentSantaCruz * totPopulasjon) / 100;

			Debug.Log("Tursiter som drar = " + Turister_drar + " og turister som kommer er = " + Turister_kommer);
			totTurister = Turister_kommer - Turister_drar;
			Debug.Log ("totalt antall turister = " + totTurister);
			turisterFernandina =(int)Math.Floor (totTurister * 0.2);
			if(turisterFernandina >= islandInfo.maxTurismeFernandina){
				turisterFernandina = islandInfo.maxTurismeFernandina;
			}
			islandInfo.nyeTuristerFernandina = turisterFernandina;
			turisterIsabela =(int)Math.Floor (totTurister * 0.2);
			if(turisterIsabela >= islandInfo.maxTurismeIsabela){
				turisterIsabela = islandInfo.maxTurismeIsabela;
			}
			islandInfo.nyeTuristerIsabela = turisterIsabela;
			turisterSanCristobal =(int)Math.Floor (totTurister * 0.4);
			if(turisterSanCristobal >= islandInfo.maxTurismeSanCristobal){
				turisterSanCristobal = islandInfo.maxTurismeSanCristobal;
			}
			islandInfo.nyeTuristerSanCristobal = turisterSanCristobal;
			turisterSanSalvador =(int)Math.Floor (totTurister * 0.1);
			if(turisterSanSalvador >= islandInfo.maxTurismeSanSalvador){
				turisterSanSalvador = islandInfo.maxTurismeSanSalvador;
			}
			islandInfo.nyeTuristerSanSalvador = turisterSanSalvador;
			turisterSantaCruz =(int)Math.Floor (totTurister * 0.1);
			if(turisterSantaCruz >= islandInfo.maxTurismeSantaCruz){
				turisterSantaCruz = islandInfo.maxTurismeSantaCruz;
			}
			islandInfo.nyeTuristerSantaCruz = turisterSantaCruz;
			Debug.Log ("Turister isabela: " + turisterIsabela);

			///////Oppdaterer mengden søppel
			ForsoplingFernandina = islandInfo.forsoplingFernandina - (islandInfo.ansatteFernadina * 500);
			if(ForsoplingFernandina < 0){ ForsoplingFernandina = 0;}
			islandInfo.nyForsoplingFernandina = ForsoplingFernandina;

			ForsoplingIsabela = islandInfo.forsoplingIsabela - (islandInfo.ansatteIsabela * 500);
			Debug.Log ("søppel på Isabela er : " + ForsoplingIsabela);
			if(ForsoplingIsabela < 0){ ForsoplingIsabela = 0;}
			Debug.Log ("søppel på Isabela er : " + ForsoplingIsabela);
			islandInfo.nyForsoplingIsabela = ForsoplingIsabela;

			ForsoplingSanCristobal = islandInfo.forsoplingSanCristobal - (islandInfo.ansatteSanCristobal * 500);
			if(ForsoplingSanCristobal < 0){ ForsoplingSanCristobal = 0;}
			islandInfo.nyForsoplingSanCristobal = ForsoplingSanCristobal;

			ForsoplingSanSalvador = islandInfo.forsoplingSanSalvador - (islandInfo.ansatteSanSalvador * 500);
			if(ForsoplingSanSalvador < 0){ ForsoplingSanSalvador = 0;}
			islandInfo.nyForsoplingSanSalvador = ForsoplingSanSalvador;

			ForsoplingSantaCruz = islandInfo.forsoplingSantaCruz - (islandInfo.ansatteSantaCruz * 500);
			if(ForsoplingSantaCruz < 0){ ForsoplingSantaCruz = 0;}
			islandInfo.nyForsoplingSantaCruz = ForsoplingSantaCruz;


			//Deler søpla på arealet
			if(ForsoplingFernandina > 0){Forsopling_fordeltFernandina = ForsoplingFernandina / arealFernadina;}
			else {Forsopling_fordeltFernandina = 0;}
			if(ForsoplingIsabela > 0){Forsopling_fordeltIsabela = ForsoplingIsabela / arealIsabela;}
			else {Forsopling_fordeltIsabela = 0;}
			if(ForsoplingSanCristobal > 0){Forsopling_fordeltSanCristobal = ForsoplingSanCristobal / arealSanCristobal;}
			else {Forsopling_fordeltSanCristobal = 0;}
			if(ForsoplingSanSalvador > 0){Forsopling_fordeltSanSalvador = ForsoplingSanSalvador / arealSanSalvador;}
			else {Forsopling_fordeltSanSalvador = 0;}
			if(ForsoplingSantaCruz > 0){Forsopling_fordeltSantaCruz = ForsoplingSantaCruz / arealSantaCruz;}
			else {Forsopling_fordeltSantaCruz = 0;}
			Forsopling_fordeltHav = ForsoplingHav / 90000000;
			//Oppdaterer søppel fra mennesker
			totSoppel_fra_mennesker = (int)((totTurister + totPopulasjon) / 60);

			Debug.Log ("Økonomi = " + okonomi);
			test++;
			Debug.Log ( "TEST ER " + test);

			if(islandInfo.visitedFernadina == true){
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (0); 
			} else if(islandInfo.visitedIsabela == true){
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (1); 
			} else if(islandInfo.visitedSanCristobal == true){
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (2); 
			} else if (islandInfo.visitedSanSalvador == true){
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (3); 
			} else if(islandInfo.visitedSantaCruz == true){
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showText (4);
			}

			Debug.Log ("HER KOMMER DYRENE TIL FERNANDINA");
			Debug.Log ("Iguana fertil: " + Iguana_FertilFernandina);
			Debug.Log ("Iguana unge: " + Iguana_UngFernandina);
			Debug.Log ("Pelican fertil: " + Brown_Pelican_FertilFernandina);
			Debug.Log ("Pelican ung: " + Brown_Pelican_UngeFernandina);
			Debug.Log ("DYR SOM HØRER TIL HAVET");
			Debug.Log ("Hai fertil: " + Hai_Fertil);
			Debug.Log ("Hai unge: " + Hai_Unge);
			Debug.Log ("Sjopolse fertil: " + Sjopolse_Fertil);
			Debug.Log ("Sjopolse ung: " + Sjopolse_Unge);
			Debug.Log ("Fisk fertil: " + Fertil_Fisk);
			Debug.Log ("Fisk yngel: " + Yngel);
		}
		
		//I tilfelle det blir månedskifte settes disse lik hverandre
		forrigeuke = uker;
		forrigemaande = maander;
	}
	
	int oppdatererAntall_jobber(int Aj)
	{
		//Her finner vi ut hvor mange som må flytte hit for å fylle opp resten av jobbene
		if (Aj > totPopulasjon)
		{
			Aj -= totPopulasjon;
		}
		
		return (Aj);
	}
	
	int updatePelican(int fertilBrownPelican, int ungBrownPelican, int Plass_BP_trenger, int Tilgjengelig_BP_plass)
	{
		//Lager variablene som vi trenger for å regne ut hvor mange fertile pelikaner det er
		int BPvokseropp = 0;
		int BPFdorAlderdom = 0;
		int BPFdorForsopling = 0;
		//Lager en teller for å holde styr på når BP skal vokse opp.
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		double teller = maander-(aar*12);
		
		//Hvis det er månedskifte så sjekker den om vi er i spessielle måneder
		if (maander > forrigemaande)
		{
			if (teller == 1)
			{
				//Som i denne måneden vokser ungene opp til voksne
				BPvokseropp = ungBrownPelican / 4;
				
			}
			else if (teller == 11)
			{
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
	
	int updatePelicanUnge (int fertilBrownPelican, int ungBrownPelican, int Plass_BP_trenger, int Tilgjengelig_BP_plass)
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
				pelicanKlekkes = (int)(fertilBrownPelican / 2) * 3;
				BPvokseropp = (int)ungBrownPelican / 4;
				Debug.Log ("Er skjer det skumle ting1111111111");
			}
		}
		
		if (Plass_BP_trenger > Tilgjengelig_BP_plass)
		{
			//Dette skjer hvis det er for lite plass for policanen
			//Da dør 30%(0.3) av pelikanene
			//(int) er for å konvertere til int fra hva slags annet tall det ville være
			//Math.Floor runder tallet ned
			BPdorforsopling = (int)Math.Floor(Brown_Pelican_Unge * 0.3);
			Debug.Log ("Er skjer det skumle ting1111111111");
		}
		
		//Regner sammen både innput og output
		ungBrownPelican = ungBrownPelican+(pelicanKlekkes-BPvokseropp-BPdorforsopling);
		return ungBrownPelican;
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
			if (teller == 1)
			{
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
			Debug.Log("fisken dølaer");
		}
		
		//Regner sammen antall fisk
		totFFisk = totFFisk + (fiskVokserOpp - FiskblirGammel - dorAvAlderdom - dorPgaForsopling - spistFugl - spistHai);
		return totFFisk;
	}
	
	int updateForsopling(int totForsopling, int Oppryddere)
	{
		//§
		//Oppdaterer forsøplinga
		//Input og oputput variabler
		int innSoppel = totSoppel_fra_mennesker;
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
			Debug.Log ("hallo haien dør");
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
	
	int updateIguanafertil(int fertilIguana, int ungIguana, int Plass_iguana_trenger, int Tilgjengelig_Iguana_plass)
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
				Iguana_blir_voksen = ungIguana/5;
				Debug.Log ("Er skjer det skumle ting 1111 "); 
			}
			else if (teller == 12)
			{
				//Iguana dør av alderdom
				Dor_av_alderdom_Iguana = fertilIguana/8;
				Debug.Log ("Er skjer det skumle ting 22");
			}
		}
		
		if (Plass_iguana_trenger > Tilgjengelig_Iguana_plass)
		{
			//Dør på grunn av liten plass
			Dor_av_forsopling_iguana_fertil= (int)Math.Floor(fertilIguana* 0.2);
			Debug.Log ("Er skjer det skumle ting");
		}
		
		fertilIguana = fertilIguana + (Iguana_blir_voksen-Dor_av_forsopling_iguana_fertil- Dor_av_alderdom_Iguana);
		return fertilIguana;
	}
	
	int updateIguanaunge (int fertilIguana, int ungeIguana, int Plass_iguana_trenger, int Tilgjengelig_Iguana_plass)
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
				Debug.Log ("Er skjer det skumle ting21");
			}
			else if (teller == 4)
			{
				//Iguana blirn født
				Iguana_fodt = Iguana_Fertil*2;
				Debug.Log ("Er skjer det skumle ting12");
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
		//int sparing = (int)Math.Floor (totOkonomi*0.3);
		int Penger_politi = 0;
		int Penger_Oppryddere = 0;
		Inntekter = penger_fra_turister_og_innbyggere;
		Debug.Log ("Inntekter: " + Inntekter);
		//Trenger ikke teller fordi dette skal skje hver måned
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		if (maander > forrigemaande) 
		{
			//Tar penger fra turister og innbyggere
			//Stjeler litt fra dyrene også med det snakker vi ikke om
<<<<<<< HEAD
			Inntekter = penger_fra_turister_og_innbyggere;
			Penger_politi = Politi*700;
			Penger_Oppryddere = totAntallOppryddere*300;
			Debug.Log("Betaler opprydderne: " + Penger_Oppryddere);
		}
		
=======

			Inntekter = penger_fra_turister_og_innbyggere;
			Penger_politi = Politi*700;
			Penger_Oppryddere = totAntallOppryddere*300;
		}

>>>>>>> JOhn
		totOkonomi = totOkonomi + (Inntekter - Penger_politi - Penger_Oppryddere);
		if (totOkonomi <= 0) {
			totOkonomi = 0;
		}
		okonomi =okonomi + (Inntekter - Penger_politi - Penger_Oppryddere);
		if (okonomi <= 0) {
			okonomi = 0;
		}
		Debug.Log ("okonomi etter lønninger: " + okonomi);
		return totOkonomi;
	}
	
	int updatePopulasjon (int Populasjon)
	{
		//Variabler input og output
		int Folk_inn = Flytter_pga_jobb;
		int Folk_flytter = 0;
		
		if (Antall_jobber < totPopulasjon)
		{
			//Regner ut folk som flytter pga lite jobber
			Folk_flytter = totPopulasjon-Antall_jobber;
		}
		
		Populasjon = Populasjon + (Folk_inn - Folk_flytter);
		return Populasjon;
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
		
		if (Sjopolse_Fertil < 1000000000)                       //9 nuller
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
			Debug.Log ("fisken dør ");
		}
		
		totYngel = totYngel + (Fisk_klekkes - fisk_blir_voksen - Dor_pga_forsopling_Fisk_Y);
		return totYngel;
	}
}