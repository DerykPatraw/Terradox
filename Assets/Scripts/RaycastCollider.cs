using UnityEngine;
using System.Collections;

public class RaycastCollider : MonoBehaviour {

	void Update() {
		Vector3 fwd = transform.TransformDirection(Vector3.forward); 
		if (Physics.Raycast (transform.position, fwd, 3)) { //shoot ray forward. If ray hits something...
			print ("There is something in front of the object!");
		}
		else {
			print("There is nothing here.");
		}
	}
}