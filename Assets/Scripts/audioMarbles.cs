using UnityEngine;
using System.Collections;

public class audioMarbles : MonoBehaviour {
		void OnTriggerEnter () {
		AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
}
