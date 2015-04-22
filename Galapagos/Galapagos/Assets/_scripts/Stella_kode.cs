using UnityEngine;
using UnityEngine.UI;
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
	public static int pengerFraTurister = 150;
	public static int oppryddereRydder = 125;
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
	
	
//	float Forsopling_fordeltFernandina = 0;
//	float Forsopling_fordeltIsabela = 0;
//	float Forsopling_fordeltSanCristobal = 0;
//	float Forsopling_fordeltSanSalvador = 0;
//	float Forsopling_fordeltSantaCruz = 0;
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
	public static int totTurister = 100;
	int Turister_kommer = 0;
	int Turister_drar = 0;
	int Turisme = 0;
	int penger_fra_turister_og_innbyggere = 0;
	
	//Hai
	public static int Hai_Fertil = 5000;
	public static int Hai_Unge = 30000;
	
	//Iguana
	public static int Iguana_Fertil = 20000;
	public static int Iguana_Unge = 80000;
	
	//Sjøpølse
	public static int Sjopolse_Fertil = 1000000;
	public static int Sjopolse_Unge = 2000000;
	
	//Okonomien er gjort public for å kunne eksperementere med i Unity
	public static int okonomi = 10000;
	
	//Lovlig fiske
	int Fisking = 780;
	
	//Interesse rundt ulovlig fiske
	int Informerte_Hai = 0;
	int Informerte_om_sjopolse = 0;
	
	//Rykte eller reklame som dyrene lager
	int Hai_Reklame = 0;
	int Iguana_Reklame = 0;
	int Pelican_Reklame = 0;
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
	
	//int totalAreal;
	
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

	public static int slutter;
	public static int mangler;
	public static int ekstraReklame;
	public static int ekstraSjopolseReklame;
	public static int ekstraHaiReklame;

	int test = 0;

	public static int eventTourists = 0;
	
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

		prosentFernadina = 8.44f;
		prosentIsabela = 62.76f;
		prosentSanCristobal = 7.55f;
		prosentSanSalvador = 7.91f;
		prosentSantaCruz = 13.34f;
		
		//Regner ut total areal av alle øyene7
		//totalAreal = arealFernadina + arealIsabela + arealSanCristobal+arealSanSalvador+arealSantaCruz;

		//Har definert hvor mange pelikaner det er over så nå deler jeg det mellom øyene basert på hvor stor øyene er.
		//Gjør det samme med Iguana. Trenger bare å gjøre det med disse to siden de er land dyr.
		Brown_Pelican_FertilFernandina = (int) (prosentFernadina * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilIsabela = (int)(prosentIsabela * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilSanCristobal = (int)(prosentSanCristobal * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilSanSalvador = (int)(prosentSanSalvador * Brown_Pelican_Fertil / 100);
		Brown_Pelican_FertilSantaCruz = (int)(prosentSantaCruz * Brown_Pelican_Fertil / 100);


		Brown_Pelican_UngeFernandina = (int)(prosentFernadina * Brown_Pelican_Unge / 100);
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
		if (pause.isPaused == false) {
			timer += Time.deltaTime;
			uker = (int)Math.Floor (timer / antallSekundermellomUker);
			maander = (int)(uker / 4);
			aar = (int)(maander / 12);
		}

		oppryddereFernandina = islandInfo.ansatteFernadina;
		oppryddereIsabela = islandInfo.ansatteIsabela;
		oppryddereSanCristobal = islandInfo.ansatteSanCristobal;
		oppryddereSanSalvador = islandInfo.ansatteSanSalvador;
		oppryddereSantaCruz = islandInfo.ansatteSantaCruz;
		
		if (uker > forrigeuke) {
			///////Oppdaterer mengden søppel
			ForsoplingFernandina = ForsoplingFernandina + ((islandInfo.turisterFernandina * 15) + (islandInfo.populasjonFernandina * 15));
			if(ForsoplingFernandina < 0){ ForsoplingFernandina = 0;}

			
			ForsoplingIsabela = ForsoplingIsabela + ((islandInfo.turisterIsabela * 15) + (islandInfo.populasjonIsabela * 15));
			if(ForsoplingIsabela < 0){ ForsoplingIsabela = 0;}

			ForsoplingSanCristobal = ForsoplingSanCristobal + ((islandInfo.turisterSanCristobal * 15) + (islandInfo.populasjonSanCristobal * 15));
			if(ForsoplingSanCristobal < 0){ ForsoplingSanCristobal = 0;}

			
			ForsoplingSanSalvador = ForsoplingSanSalvador + ((islandInfo.turisterSanSalvador * 15) + (islandInfo.populasjonSanSalvador * 15));
			if(ForsoplingSanSalvador < 0){ ForsoplingSanSalvador = 0;}

			
			ForsoplingSantaCruz = ForsoplingSantaCruz + ((islandInfo.turisterSantaCruz * 15) + (islandInfo.populasjonSantaCruz * 15));
			if(ForsoplingSantaCruz < 0){ ForsoplingSantaCruz = 0;}
			islandInfo.forsoplingSantaCruz = ForsoplingSantaCruz;
			
			
			Forsopling_fordeltHav = ForsoplingHav / 90000000;
			//Oppdaterer søppel fra mennesker
			totSoppel_fra_mennesker = (int)((totTurister + totPopulasjon) / 60);
			ForsoplingFernandina = updateForsopling (ForsoplingFernandina, oppryddereFernandina);
			islandInfo.forsoplingFernandina = ForsoplingFernandina;

			ForsoplingIsabela = updateForsopling (ForsoplingIsabela, oppryddereIsabela);
			islandInfo.forsoplingIsabela = ForsoplingIsabela;
			ForsoplingSanCristobal = updateForsopling (ForsoplingSanCristobal, oppryddereSanCristobal);
			islandInfo.forsoplingSanCristobal = ForsoplingSanCristobal;
			ForsoplingSanSalvador = updateForsopling (ForsoplingSanSalvador, oppryddereSanSalvador);
			islandInfo.forsoplingSanSalvador = ForsoplingSanSalvador;
			ForsoplingSantaCruz = updateForsopling (ForsoplingSantaCruz, oppryddereSantaCruz);
			islandInfo.forsoplingSantaCruz = ForsoplingSantaCruz;
			ForsoplingHav = updateForsopling (ForsoplingHav, oppryddereHav);

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

			if((Brown_Pelican_FertilFernandina + Brown_Pelican_UngeFernandina) <= 16){
				ekstraReklame += 70;
				newsFeed.disasterNews(16);
			}
			if((Brown_Pelican_FertilIsabela + Brown_Pelican_UngeIsabela) <= 125){
				ekstraReklame += 200;
				newsFeed.disasterNews(17);
			}
			if((Brown_Pelican_FertilSanCristobal + Brown_Pelican_UngeSanCristobal) <= 15){
				ekstraReklame += 50;
				newsFeed.disasterNews(18);
			}
			if((Brown_Pelican_FertilSanSalvador + Brown_Pelican_UngeSanSalvador) <= 16){
				ekstraReklame += 60;
				newsFeed.disasterNews(19);
			}
			if((Brown_Pelican_FertilSantaCruz + Brown_Pelican_UngeSantaCruz) <= 27){
				ekstraReklame += 100;
				newsFeed.disasterNews(20);
			}
			
			//Oppdaterer pengene vi får inn
			penger_fra_turister_og_innbyggere = totTurister * pengerFraTurister + totPopulasjon * 50;

			//Regner ut plassen for dyrene å leve på
			Tilgjengelig_BP_plassFernandia = ((arealFernadina) - (ForsoplingFernandina));
			Tilgjengelig_BP_plassIsabela = ((arealIsabela) - (ForsoplingFernandina));
			Tilgjengelig_BP_plassSanCristobal = ((arealSanCristobal) - (ForsoplingSanCristobal));
			Tilgjengelig_BP_plassSanSalvador =  ((arealSanSalvador) - (ForsoplingSanSalvador));
			Tilgjengelig_BP_plassSantaCruz =  ((arealSantaCruz) - (ForsoplingSantaCruz));
			
			Tilgjengelig_Iguana_plassFernandina =((arealFernadina) - (ForsoplingFernandina));
			Tilgjengelig_Iguana_plassIsabela =  ((arealIsabela) - (ForsoplingFernandina));
			Tilgjengelig_Iguana_plassSanCristobal =  ((arealSanCristobal) - (ForsoplingSanCristobal));
			Tilgjengelig_Iguana_plassSanSalvador =  ((arealSanSalvador) - (ForsoplingSanSalvador));
			Tilgjengelig_Iguana_plassSantaCruz =  ((arealSantaCruz) - (ForsoplingSantaCruz));
			
			Tilgjengelig_Fisk_plass = (int)(90000000 - Forsopling_fordeltHav);
			Tilgjengelig_Hai_plass = (int)(90000000 - Forsopling_fordeltHav);
			Tilgjengelig_Sjopolse_plass = (int)Math.Ceiling (4500000 - Forsopling_fordeltHav);
			
			
			
			Debug.Log (uker);
			
			//Regner ut hvor mange som flytter på grunn av jobb
			//
			Flytter_pga_jobb = oppdatererAntall_jobber (Flytter_pga_jobb);
			
			//Oppdaterer fiskebestanden
			Fertil_Fisk = updateFertilFisk (Fertil_Fisk);
			Yngel = updateYngel (Yngel);
			//Ser hvor mye søppel folk har lagt igjen

			
			//Oppdaterer haibestanden
			Hai_Fertil = updateHaifertil (Hai_Fertil);
			Hai_Unge = updateHaiunge (Hai_Unge);
			if((Hai_Fertil + Hai_Unge) <= 7000){ekstraHaiReklame += 500;}
			//Oppdaterer sjøpølse bestanden
			Sjopolse_Fertil = updateSjopolsefertil (Sjopolse_Fertil);
			Sjopolse_Unge = updateSjopolseung (Sjopolse_Unge);
			if((Sjopolse_Fertil + Sjopolse_Unge) <= 240000){ekstraSjopolseReklame += 500;}

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

			if((Iguana_FertilFernandina + Iguana_UngFernandina) <= 337){
				ekstraReklame += 200;
				newsFeed.disasterNews(11);
			}
			if((Iguana_FertilIsabela + Iguana_UngIsabela) <= 2510){
				ekstraReklame += 200;
				newsFeed.disasterNews(12);
			}
			if((Iguana_FertilSanCristobal + Iguana_UngSanCristobal) <= 302){
				ekstraReklame += 200;
				newsFeed.disasterNews(13);
			}
			if((Iguana_FertilSanSalvador + Iguana_UngSanSalvador) <= 316){
				ekstraReklame += 200;
				newsFeed.disasterNews(14);
			}
			if((Iguana_FertilSantaCruz + Iguana_UngSantaCruz) <= 533){
				ekstraReklame += 200;
				newsFeed.disasterNews(15);
			}

			//Oppdaterer hvor mye rykte dyrene sprer
			Hai_Reklame = (int)Math.Floor (Hai_Fertil * 0.01 + Hai_Unge * 0.01);
			Iguana_Reklame = (int)Math.Floor ((Iguana_Fertil * 0.01) + (Iguana_Unge * 0.001));
			Pelican_Reklame = (int)Math.Floor ((Brown_Pelican_Fertil * 0.01) + (Brown_Pelican_Unge * 0.001));
			Sjopolse_Reklame = (int)Math.Floor ((Sjopolse_Unge + Sjopolse_Fertil) * 0.00007);
			Reklame = (int)Math.Floor ((totTurister * 0.1) + Hai_Reklame + Iguana_Reklame + Sjopolse_Reklame + Pelican_Reklame + ekstraReklame);
			
			//Oppdaterer hvor mange som har hørt om hai fisk og sjøpølse fisking
			Informerte_om_sjopolse = (int)Math.Ceiling (Sjopolse_Reklame * 0.01 + ekstraSjopolseReklame);
			Informerte_Hai = (int)Math.Ceiling (Hai_Reklame * 0.1 + ekstraHaiReklame);

			//Oppdaterer populasjonen etter endringen som har skjedd
			totPopulasjon = updatePopulasjon (totPopulasjon);

			//Oppdaterer Tyvfiskerne
			Tyvfiskere_Hai = updateTyvfiskereHai (Tyvfiskere_Hai);
			Tyvfiskere_Sjopolse = updateTyvfiskereSjopolse (Tyvfiskere_Sjopolse);

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
			//Turist conveyer
			//I månedskiftet drar de turistene som kom for en måned siden, mens nye turister kommer.
			
			//if (maander > forrigemaande) {
			Turister_drar = totTurister;
			movingIn = (int)Math.Floor (totTurister * 0.1);
			Debug.Log ("Moving in: " + movingIn);
			totPopulasjon = totPopulasjon + movingIn;
			Debug.Log("tot populasjon: " + totPopulasjon);
			Turister_kommer = Reklame;
			populasjonFernandina = (int)(prosentFernadina * totPopulasjon) / 100;
			populasjonIsabela = (int)(prosentIsabela * totPopulasjon) / 100;
			populasjonSanCristobal = (int)(prosentSanCristobal * totPopulasjon) / 100;
			populasjonSanSalvador = (int)(prosentSanSalvador * totPopulasjon) / 100;
			populasjonSantaCruz = (int)(prosentSantaCruz * totPopulasjon) / 100;

			//Her fordeles turistene mellom øyene
			//Tester og om det kommer for mange enn det er plass til. Om det er tilfellet vil det bare komme så
			//mange det er plass til
			totTurister = Turister_kommer + eventTourists;
			eventTourists = 0;

			//Her begrenses turismen basert på hva spilleren har valgt i begrensningsmenyen
			//Er det for mange turister vil bare det maksimale antallet som får lov til å komme inn, bli.
			if(totTurister >= begrensninger.maxTurister){
				totTurister = (int)begrensninger.maxTurister;
			}
			//Sender den totale mengden turister inn til fordelTurisme() funksjonen
			fordelTurisme(totTurister);

			//Oppdaterer pengene vi får inn
			penger_fra_turister_og_innbyggere = totTurister * 37 + totPopulasjon * 20;
			//Oppdaterer økonomien
			okonomi = updateOkonomi (okonomi);

			test++;

			int doomedAnimals = 0;
			int healthyAnimals = 0;
			bool looseTourism = false;
			bool looseAnimal = false;
			bool greatAnimals = false;
			bool greatTourism = false;
			if((Brown_Pelican_FertilFernandina + Brown_Pelican_UngeFernandina) <= 6){
				doomedAnimals ++;
			}
			if((Brown_Pelican_FertilIsabela + Brown_Pelican_UngeIsabela) <= 32){
				doomedAnimals ++;
			}
			if((Brown_Pelican_FertilSanCristobal + Brown_Pelican_UngeSanCristobal) <= 5){
				doomedAnimals ++;
			}
			if((Brown_Pelican_FertilSanSalvador + Brown_Pelican_UngeSanSalvador) <= 5){
				doomedAnimals ++;
			}
			if((Brown_Pelican_FertilSantaCruz + Brown_Pelican_UngeSantaCruz) <= 7){
				doomedAnimals ++;
			}
			if((Iguana_FertilFernandina + Iguana_UngFernandina) <= 85){
				doomedAnimals ++;
			}
			if((Iguana_FertilIsabela + Iguana_UngIsabela) <= 628){
				doomedAnimals ++;
			}
			if((Iguana_FertilSanCristobal + Iguana_UngSanCristobal) <= 75){
				doomedAnimals ++;
			}
			if((Iguana_FertilSanSalvador + Iguana_UngSanSalvador) <= 316){
				doomedAnimals ++;
			}
			if((Iguana_FertilSantaCruz + Iguana_UngSantaCruz) <= 133){
				doomedAnimals ++;
			}

			if(Brown_Pelican_FertilFernandina + Brown_Pelican_FertilIsabela + Brown_Pelican_FertilSanCristobal + Brown_Pelican_FertilSanSalvador + Brown_Pelican_FertilSantaCruz >= 500){
				healthyAnimals++;
			}
			if(Iguana_FertilFernandina + Iguana_FertilIsabela + Iguana_FertilSanCristobal + Iguana_FertilSanSalvador + Iguana_FertilSantaCruz >= 10000){
				healthyAnimals++;
			}
			if(Hai_Fertil >= 2500){
				healthyAnimals++;
			}
			if(Sjopolse_Fertil >= 500000){
				healthyAnimals++;
			}
			if(doomedAnimals >= 3){looseAnimal = true;} //Dersom 3 arter er på 5% av sin originale populasjon aktiveres tap bool
			else{looseAnimal = false;} //Om ikke vil den deaktiveres

			if(totTurister <= 50){looseTourism = true;} //Dersom spilleren har mindre enn 50 turister aktiveres tap bool
			else{looseTourism = false;} //Om ikke vil den deaktiveres

			if(healthyAnimals >= 4){greatAnimals = true;}
			else{greatAnimals = false;}

			if(totTurister >= 2000){greatTourism = true;}
			else{greatTourism = false;}

			winLoose.checkAnimalTourism(looseAnimal, looseTourism, greatAnimals, greatTourism);

			//Sjekker om spilleren ser på en øy.
			//Om det er tilfellet skal den nye informasjonen vises
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

			weeklyChange.updateFernandina((Iguana_FertilFernandina+Iguana_UngFernandina),(Brown_Pelican_FertilFernandina+Brown_Pelican_UngeFernandina));
			Debug.Log ((Iguana_FertilFernandina+Iguana_UngFernandina));
			if(mouseClicker.visitedWeekly == true){
				GameObject.Find ("MainCamera").GetComponent<mouseClicker> ().showWeekly();
			}
			ekstraHaiReklame = 0;
			ekstraReklame = 0;
			ekstraSjopolseReklame = 0;
		}
		
		//I tilfelle det blir månedskifte settes disse lik hverandre
		forrigeuke = uker;
		forrigemaande = maander;
	}

	//Denne funksjonen tar seg av fordelingen av turisme
	//Er det satt opp sperringer vil denne ta seg av det og fordele turistene gjevnt over alle tilgjengelige øyer
	void fordelTurisme(int totTurister)
	{
		int rest = 0; //variabel som holder på hvor mange turister det er til overs
		int ant = 5; //Variabel som sier hvor mange øyer som er åpne for turisme


		//Sjekker om grensen er stengt eller ikke
		//Er den stengt vil ant minske med 1, og rest vil øke med antall turister til overs
		if (islandInfo.f_isClosed == true) {
			turisterFernandina = 0;
			rest = (int) Math.Floor (rest + totTurister * 0.2);
			ant --;
		}
		if (islandInfo.i_isClosed == true) {
			turisterIsabela = 0;
			rest = (int) Math.Floor (rest + totTurister * 0.2);
			ant --;
		}
		if (islandInfo.sc_isClosed == true) {
			turisterSanCristobal = 0;
			rest = (int) Math.Floor (rest + totTurister * 0.4);
			ant --;
		}
		if (islandInfo.ss_isClosed == true) {
			turisterSanSalvador = 0;
			rest = (int) Math.Floor (rest + totTurister * 0.1);
			ant --;
		}
		if (islandInfo.sz_isClosed == true) {
			turisterSantaCruz = 0;
			rest = (int) Math.Floor (rest + totTurister * 0.1);
			ant --;
		}

		//Dersom en øy ikke er stengt skal den få turister
		if (islandInfo.f_isClosed == false) {
			turisterFernandina = (int)Math.Floor ((totTurister * 0.1) + (rest / ant)); 	//Regner ført ut turisterX. Merk at rest / ant, noe som betyr at lavere ant = høyere tall
			if(turisterFernandina >= islandInfo.maxTurismeFernandina){ //Dersom det er flere turister enn det er plass til skjer:
				rest = rest + islandInfo.maxTurismeFernandina - turisterFernandina; //Rest får gjenværende turister
				turisterFernandina = islandInfo.maxTurismeFernandina; //Antall turister settes til maks antall mulige
			}
		}
		if (islandInfo.i_isClosed == false) {
			turisterIsabela = (int)Math.Floor ((totTurister * 0.4) + (rest / ant));
			if(turisterIsabela >= islandInfo.maxTurismeIsabela){
				rest = rest + islandInfo.maxTurismeIsabela - turisterIsabela;
				turisterIsabela = islandInfo.maxTurismeIsabela;
			}
		}
		if (islandInfo.sc_isClosed == false) {
			turisterSanCristobal = (int)Math.Floor ((totTurister * 0.2) + (rest / ant));
			if(turisterSanCristobal >= islandInfo.maxTurismeSanCristobal){
				rest = rest + islandInfo.maxTurismeSanCristobal - turisterSanCristobal;
				turisterSanCristobal = islandInfo.maxTurismeSanCristobal;
			}
		}
		if (islandInfo.ss_isClosed == false) {
			turisterSanSalvador = (int)Math.Floor ((totTurister * 0.1) + (rest / ant));
			if(turisterSanSalvador >= islandInfo.maxTurismeSanSalvador){
				rest = rest + islandInfo.maxTurismeSanSalvador - turisterSanSalvador;
				turisterSanSalvador = islandInfo.maxTurismeSanSalvador;
			}
		}
		if (islandInfo.sz_isClosed == false) {
			turisterSantaCruz = (int)Math.Floor ((totTurister * 0.2) + (rest / ant));
			if(turisterSantaCruz >= islandInfo.maxTurismeSantaCruz){
				rest = rest + islandInfo.maxTurismeSantaCruz - turisterSantaCruz;
				turisterSantaCruz = islandInfo.maxTurismeSantaCruz;
			}
		}

		islandInfo.nyeTuristerFernandina = turisterFernandina;
		islandInfo.nyeTuristerIsabela = turisterIsabela;
		islandInfo.nyeTuristerSanCristobal = turisterSanCristobal;
		islandInfo.nyeTuristerSanSalvador = turisterSanSalvador;
		islandInfo.nyeTuristerSantaCruz = turisterSantaCruz;
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
		if (fertilBrownPelican <= 0) {
			fertilBrownPelican = 0;
		}

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
		if (ungBrownPelican <= 0) {
			ungBrownPelican = 0;
		}
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
		
		//if (maander > forrigemaande)
		//{
			//I månedsskiftet kaster vi søppel
			ryddaSoppel = Oppryddere*oppryddereRydder;
		//}
		
		totForsopling = totForsopling + (innSoppel - ryddaSoppel);
		if (totForsopling <= 0) {
			totForsopling = 0;
		}
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
		if (fertilHai <= 0) {
			fertilHai = 0;
		}
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
		if (ungHai <= 0) {
			ungHai = 0;
		}
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
		if (fertilIguana <= 0) {
			fertilIguana = 0;
		}
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
				Debug.Log ("Er skjer det skumle ting211111111111111111111111111111111111111111111111111111");
			}
			else if (teller == 4)
			{
				//Iguana blirn født
				Iguana_fodt = Iguana_Fertil*2;
				Debug.Log ("Er skjer det skumle ting1222222222222222222222222222222222222222222222222222222");
			}
		}
		
		if (Plass_iguana_trenger > Tilgjengelig_Iguana_plass)
		{
			//Lite plass, mindre iguana
			Dor_av_forsopling_iguana_Unge = (int)Math.Floor (Iguana_Unge*0.2);
		}
		//Iguana_UngFernandina = updateIguanaunge (Iguana_FertilFernandina, Iguana_UngFernandina, Plass_iguana_trengerFernandina, Tilgjengelig_Iguana_plassFernandina);

		ungeIguana = ungeIguana + (Iguana_fodt - Iguana_blir_voksen - Dor_av_forsopling_iguana_Unge);
		if (ungeIguana <= 0) {
			ungeIguana = 0;
		}
		return ungeIguana;
	}
	
	int updateOkonomi(int totOkonomi)
	{
		//Variabler for input og output
		int Inntekter = 0;
		//int sparing = (int)Math.Floor (totOkonomi*0.3);
		int Penger_politi = 0;
		int Penger_Oppryddere = 0;

		bool looseMoney = false;
		bool winMoney = false;

		Inntekter = penger_fra_turister_og_innbyggere;
		//Trenger ikke teller fordi dette skal skje hver måned
		//Dette er en oversettelse av funksjonen PULSE i stella til C#
		if (maander > forrigemaande) {
			//Tar penger fra turister og innbyggere
			//Stjeler litt fra dyrene også med det snakker vi ikke om
			Inntekter = penger_fra_turister_og_innbyggere;
			Penger_politi = Politi * 700;
			Penger_Oppryddere = totAntallOppryddere * 300;
			Debug.Log ("Betaler opprydderne: " + Penger_Oppryddere);
		}
		Debug.Log ("NumPoliti = " + Politi);
		Debug.Log ("NumOppryddere = " + totAntallOppryddere);
		int lonning = Penger_politi + Penger_Oppryddere; // Regner ut lønningene denne måneden
		int lommeboks = totOkonomi + Inntekter; //Regner ut pengene spilleren har når lønninger skal utbetales
		int betalPoliti;
		int betalOppryddere;
		int totAnsatte;
		Debug.Log ("lonning = " + lonning);
		Debug.Log ("lommeboks = " + lommeboks);
		//Tester om lønningene som skal utbetales er større enn pengene spilleren har
		if (lonning > lommeboks) {
			totOkonomi = 0; //Setter økonomien lik 0 for å forhindre -penger
			okonomi = 0; //Setter økonomien lik 0 for å forhindre -penger
			totAnsatte = Politi + totAntallOppryddere; //Regner ut totalt antall ansatte
			Debug.Log ("totAnsatte = " + totAnsatte);
			betalPoliti = (100 * Politi) / totAnsatte; //Regner ut hvor mange prosent av de ansatte som er politi
			Debug.Log ("betalPoliti = " + betalPoliti);
			betalOppryddere = (100 * totAntallOppryddere) / totAnsatte; //Regner ut hvor mange prosent av de ansatte som er oppryddere
			Debug.Log ("betalOppryddere = " + betalOppryddere);
			Politi = betalPoliti; //Endrer så bare dem som ble betalt gjenstår som politi
			Debug.Log ("Politi = " + Politi);
			totAntallOppryddere = betalOppryddere;//Endrer så bare dem som ble betalt gjenstår som oppryddere
			Debug.Log ("totAntallOppryddere = " + totAntallOppryddere);
			//Fordeler de ansatte på øyene
			oppryddereFernandina -= (int)Math.Ceiling (totAntallOppryddere * 0.1);
			oppryddereIsabela -= (int)Math.Ceiling (totAntallOppryddere * 0.3);
			oppryddereSanCristobal -= (int)Math.Ceiling (totAntallOppryddere * 0.1);
			oppryddereSanSalvador -= (int)Math.Ceiling (totAntallOppryddere * 0.2);
			oppryddereSantaCruz -= (int)Math.Ceiling (totAntallOppryddere * 0.1);
			mangler = lonning - lommeboks; //Variabel som skal printes ut
			slutter = totAnsatte - (totAntallOppryddere + Politi); //Variabel som skal printes ut
			pause.pauseGame (); //Pauser spillet
			newsFeed.disasterNews(10); //Aktiverer viktig melding om at spilleren har lite penger (mindre enn 0)
			looseMoney = true;
			winMoney = false;
		} 
		else {
			totOkonomi = totOkonomi + (Inntekter - Penger_politi - Penger_Oppryddere);
			okonomi = okonomi + (Inntekter - Penger_politi - Penger_Oppryddere);

			if(okonomi >= 100000){winMoney = true;}
			looseMoney = false;
		}

		winLoose.checkMoney(looseMoney, winMoney);

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
		if (Populasjon <= 0) {
			Populasjon = 0;
		}
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
		if (fertilSjopolse <= 0) {
			fertilSjopolse = 0;
		}
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
		if (ungSjopolse <= 0) {
			ungSjopolse = 0;
		}
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
		if (totTyvfiskereHai <= 0) {
			totTyvfiskereHai = 0;
		}

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
		if (totTyvfiskereSjopolse <= 0) {
			totTyvfiskereSjopolse = 0;
		}

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