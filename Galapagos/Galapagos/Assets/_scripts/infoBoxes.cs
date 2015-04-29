using UnityEngine;
using System.Collections;

public class infoBoxes : MonoBehaviour {
	public GameObject boxPu1;
	public GameObject boxPu2;
	public GameObject boxPu3;
	public GameObject boxPu4;
	public GameObject boxPu5;
	public GameObject boxPu6;
	public GameObject boxTu1;
	public GameObject boxTu2;
	public GameObject boxTu3;
	public GameObject boxTu4;
	public GameObject boxTu5;
	public GameObject boxTu6;
	public GameObject boxSu1;
	public GameObject boxSu2;
	public GameObject boxSu3;
	public GameObject boxSu4;
	public GameObject boxSu5;
	public GameObject boxSu6;
	public GameObject close;
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (pause.isPaused == false) {
			if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu1") {
				boxPu1.transform.position = new Vector3 (-1.74f, 3.83f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu2") {
				boxPu2.transform.position = new Vector3 (-1.69f, 3.2f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu3") {
				boxPu3.transform.position = new Vector3 (-1.69f, 2.39f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu4") {
				boxPu4.transform.position = new Vector3 (-1.69f, 1.68f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu5") {
				boxPu5.transform.position = new Vector3 (-1.69f, 0.95f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "pu6") {
				boxPu6.transform.position = new Vector3 (-1.69f, 0.28f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu1") {
				boxTu1.transform.position = new Vector3 (0f, 3.83f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu2") {
				boxTu2.transform.position = new Vector3 (0f, 3.2f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu3") {
				boxTu3.transform.position = new Vector3 (0f, 2.39f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu4") {
				boxTu4.transform.position = new Vector3 (0f, 1.68f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu5") {
				boxTu5.transform.position = new Vector3 (0f, 0.95f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "tu6") {
				boxTu6.transform.position = new Vector3 (0f, 0.28f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su1") {
				boxSu1.transform.position = new Vector3 (1.4f, 3.83f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su2") {
				boxSu2.transform.position = new Vector3 (1.4f, 3.2f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su3") {
				boxSu3.transform.position = new Vector3 (1.4f, 2.39f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su4") {
				boxSu4.transform.position = new Vector3 (1.4f, 1.68f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su5") {
				boxSu5.transform.position = new Vector3 (1.4f, 0.95f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "su6") {
				boxSu6.transform.position = new Vector3 (1.4f, 0.28f, -15.0f);
				close.transform.position = new Vector3 (0, 0, -1);
				
			}
			else if (Physics.Raycast (ray, out hit, 100) && hit.transform.tag == "closeBox") {
				closeStuff ();
			}
			
		}

	}
	void closeStuff(){
		boxPu1.transform.position = new Vector3 (-1.69f, 3.83f, 0f);
		boxPu2.transform.position = new Vector3 (-1.69f, 3.2f, 0f);
		boxPu3.transform.position = new Vector3 (-1.69f, 2.39f, 0f);
		boxPu4.transform.position = new Vector3 (-1.69f, 1.68f, 0f);
		boxPu5.transform.position = new Vector3 (-1.69f, 0.95f, 0f);
		boxPu6.transform.position = new Vector3 (-1.69f, 0.28f, 0f);
		boxTu1.transform.position = new Vector3 (0f, 3.83f, 0f);
		boxTu2.transform.position = new Vector3 (0f, 3.2f, 0f);
		boxTu3.transform.position = new Vector3 (0f, 2.39f, 0f);
		boxTu4.transform.position = new Vector3 (0f, 1.68f, 0f);
		boxTu5.transform.position = new Vector3 (0f, 0.95f, 0f);
		boxTu6.transform.position = new Vector3 (0f, 0.28f, 0f);
		boxSu1.transform.position = new Vector3 (1.4f, 3.93f, 0f);
		boxSu2.transform.position = new Vector3 (1.4f, 3.2f, 0f);
		boxSu3.transform.position = new Vector3 (1.4f, 2.39f, 0f);
		boxSu4.transform.position = new Vector3 (1.4f, 1.68f, 0f);
		boxSu5.transform.position = new Vector3 (1.4f, 0.95f, 0f);
		boxSu6.transform.position = new Vector3 (1.4f, 0.28f, 0f);
		close.transform.position = new Vector3 (0f, 0f, 0f);
	}

//	void OnMouseExit(){

//		Debug.Log ("Nå stikker jeg");
//	}
}
