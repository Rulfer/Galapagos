using UnityEngine;
using System.Collections;

public class hireOpprydder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		if (isabelaScript.visitedIsabela == true) {
			isabelaScript.endreAnsatte = isabelaScript.endreAnsatte + 5;
			Debug.Log (isabelaScript.endreAnsatte);
			//isabelaScript.showText();
		} 
	
		if (sanCristobalScript.visitedSCritobal == true) {
			sanCristobalScript.endreAnsatte = sanCristobalScript.endreAnsatte +5;
		}
	}

}
