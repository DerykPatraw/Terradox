using UnityEngine;
using System.Collections;

public class TutorialCollider : MonoBehaviour {

	public GameObject Player1;
	public GameObject Player2;
	public GameObject SpawnTimer;

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "TutorialExit") {
			Destroy (Player2);
			Application.LoadLevel (1);
		}
		else if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "MarbleTutorial") {
			Destroy (SpawnTimer);
			Destroy (Player1);
			Application.LoadLevel (9);
		}
	}
}