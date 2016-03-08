using UnityEngine;
using System.Collections;

public class RaycastCollider : MonoBehaviour {

	GameObject currentMarble;
	float range = 1.8f;
	Ray ray;
	RaycastHit hit;

	void Update() {
		ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)); //ray is where camera is pointing
		if (Physics.Raycast (ray, out hit, range)) { //shoot ray forward a distance. If ray hits something...

			if (hit.collider.tag == "Marble" && Input.GetKeyDown ("e")) { //sees if the button is pressed and if it's a marble...
				Application.LoadLevel (1);

			} 
			else if (hit.collider.tag == "MarblePresent1" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (2);

			} 
			else if (hit.collider.tag == "MarbleFarPast" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (3);

			} 
			else if (hit.collider.tag == "MarblePast" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (4);

			} 
			else if (hit.collider.tag == "MarblePresent2" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (5);

			} 
			else if (hit.collider.tag == "MarbleFuture" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (6);

			} 
			else if (hit.collider.tag == "MarbleFarFuture" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (7);

			} 
			else if (hit.collider.tag == "MarblePresent3" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (0);
			}
			else if (hit.collider.tag == "MarbleTutorial" && Input.GetKeyDown ("e")) {
				Application.LoadLevel (8);
			}
			else if (hit.collider.tag == "MarbleExit" && Input.GetKeyDown("e")){
				Application.Quit();
			}
		}
		else {
			//print("There is nothing here.");
		}
	}
}