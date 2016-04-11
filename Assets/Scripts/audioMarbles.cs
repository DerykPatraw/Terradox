using UnityEngine;
using System.Collections;

public class audioMarbles : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}

	void OnTriggerEnter(Collider other) {
		if (other.GetComponent<Collider> ().tag == "Player" && this.gameObject.tag == "Marble") {
			audio.PlayOneShot (impact, 0.7F);
		}
	}
}