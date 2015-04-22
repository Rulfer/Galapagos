using UnityEngine;
using System.Collections;

public class weeklyChange : MonoBehaviour {
	public static int[] igFern = new int[10]; //Array som holder på iguanaen
	public static int[] peFern = new int[10]; //Array som holder på pelikanene

	public static int p_numFern = 0;
	public static int i_numFern = 0;



	public static void updateFernandina(int antallIguana, int antallPelican){
		if (pause.isPaused == false) {
			if (i_numFern < 9) {
				igFern [i_numFern] = antallIguana;
				i_numFern++;
			} else {
				igFern [i_numFern] = antallIguana;
				for (int i = 0; i < i_numFern; i++) {
					igFern [i] = igFern [i + 1];
				}			
			}

			if (p_numFern < 9) {
				peFern [p_numFern] = antallPelican;
				p_numFern++;
			} else {
				peFern [p_numFern] = antallPelican;
				for (int j =0; j < p_numFern; j++) {
					peFern [j] = peFern [j + 1];
				}
			}
		}
	}
}
