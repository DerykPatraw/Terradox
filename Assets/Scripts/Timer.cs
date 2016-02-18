using UnityEngine;
using System.Collections;
public class Timer : MonoBehaviour {

	float timeRemaining = 300.0f; //set initial time (Time.DeltaTime returns float)

	// Use this for initialization
	void Awake() {
		DontDestroyOnLoad (transform.gameObject); //don't destroy timer object upon new level
	}
	
	// Update is called once per frame
	void Update() {
		timeRemaining -= Time.deltaTime; //count down timeRemaining upon start
		print(timeRemaining); //show how much time is remaining
				
		if (timeRemaining < 0) {
			Application.LoadLevel(0); //when timer reaches zero, load spash plaige
		}

		if (Application.loadedLevel == 0) {
			timeRemaining = 650.0f;
		}
	}
}
