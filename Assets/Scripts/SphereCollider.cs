using UnityEngine;
using System.Collections;

public class SphereCollider : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "Marble") {
			Application.LoadLevel (Application.loadedLevel + 1);
		}
		else if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "MarbleExit") {
			Application.Quit ();
		}
		else if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "MarblePresent3") {
			Application.LoadLevel (0);
		}
		else if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "MarbleTutorial") {
			Application.LoadLevel (0);
		}
	}
}
