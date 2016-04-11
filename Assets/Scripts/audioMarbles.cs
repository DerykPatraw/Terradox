using UnityEngine;
using System.Collections;

public class audioMarbles : MonoBehaviour {

	public AudioClip teleport;
	public AudioSource sphere;
	public float volume = 1.0f;


	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "Marble") {
			sphere.PlayOneShot(teleport, 1.0f);
		}
	}
}