﻿using UnityEngine;
using System.Collections;

public class RaycastCollider : MonoBehaviour {

	GameObject currentMarble;
	float range = 1.8f;
	Ray ray;
	RaycastHit hit;

	void Update() {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition); //ray is where camera is pointing
		if (Physics.Raycast (ray, out hit, range)) { //shoot ray forward a distance. If ray hits something...
			print ("There is something in front of the object!");

			if (hit.collider.tag == "Marble" && Input.GetKeyDown("e")) { //sees if the button is pressed and if it's a marble...
				print ("You have interacted with the marble!");
			} 
		}
		else {
			print("There is nothing here.");
		}
	}
}