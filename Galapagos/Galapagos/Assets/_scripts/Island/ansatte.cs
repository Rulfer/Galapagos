using UnityEngine;
using System.Collections;

public class ansatte : MonoBehaviour {
	public static bool shopFernandina = false;
	public static bool shopIsabela = false;
	public static bool shopSanCristobal = false;
	public static bool shopSanSalvador = false;
	public static bool shopSantaCruz = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButtonDown (0)) { //Tester om spilleren klikker med musa
			
			if (pause.isPaused == false) {
				if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettEnFernandina") {
					shopFernandina = true;
					hireOpprydder.hireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettFemFernandina") {
					shopFernandina = true;
					hireOpprydder.hireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettTiFernandina") {
					shopFernandina = true;
					hireOpprydder.hireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettEnIsabela") {
					shopIsabela = true;
					hireOpprydder.hireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettFemIsabela") {
					shopIsabela = true;
					hireOpprydder.hireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettTiIsabela") {
					shopIsabela = true;
					hireOpprydder.hireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettEnSanSalvador") {
					shopSanSalvador = true;
					hireOpprydder.hireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettFemSanSalvador") {
					shopSanSalvador = true;
					hireOpprydder.hireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettTiSanSalvador") {
					shopSanSalvador = true;
					hireOpprydder.hireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettEnSanCristobal") {
					shopSanCristobal = true;
					hireOpprydder.hireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettFemSanCristobal") {
					shopSanCristobal = true;
					hireOpprydder.hireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettTiSanCristobal") {
					shopSanCristobal = true;
					hireOpprydder.hireTen();
				}  else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettEnSantaCruz") {
					shopSantaCruz = true;
					hireOpprydder.hireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettFemSantaCruz") {
					shopSantaCruz = true;
					hireOpprydder.hireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "ansettTiSantaCruz") {
					shopSantaCruz = true;
					hireOpprydder.hireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkEnFernandina") {
					shopFernandina = true;
					fireOpprydder.fireOne();
				}  else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparFemFernandina") {
					shopFernandina = true;
					fireOpprydder.fireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkTiFernandina") {
					shopFernandina = true;
					fireOpprydder.fireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkEnIsabela") {
					shopIsabela = true;
					fireOpprydder.fireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkFemIsabela") {
					shopIsabela = true;
					fireOpprydder.fireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkTiIsabela") {
					shopIsabela = true;
					fireOpprydder.fireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkEnSanSalvador") {
					shopSanSalvador = true;
					fireOpprydder.fireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkFemSanSalvador") {
					shopSanSalvador = true;
					fireOpprydder.fireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkTiSanSalvador") {
					shopSanSalvador = true;
					fireOpprydder.fireTen();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkEnSanCristobal") {
					shopSanCristobal = true;
					fireOpprydder.fireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkFemSanCristobal") {
					shopSanCristobal = true;
					fireOpprydder.fireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkTiSanCristobal") {
					shopSanCristobal = true;
					fireOpprydder.fireTen();
				}  else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkEnSantaCruz") {
					shopSantaCruz = true;
					fireOpprydder.fireOne();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkFemSantaCruz") {
					shopSantaCruz = true;
					fireOpprydder.fireFive();
				} else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "sparkTiSantaCruz") {
					shopSantaCruz = true;
					fireOpprydder.fireTen();
				} 
			}
		}
	}
}
