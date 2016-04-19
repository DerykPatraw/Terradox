using UnityEngine;
using System.Collections;
//The commands for the teleporting system
public class SphereCollider : MonoBehaviour {
	//Main spawn system

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "Marble") { //Checks the tags and colliders, and if match teleports you to next level
			Application.LoadLevel (Application.loadedLevel + 1);
		}
		else if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "MarbleExit") {
			Application.Quit ();
		}
		else if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "MarblePresent3") {
			Application.LoadLevel (10);
		}
	}
}
