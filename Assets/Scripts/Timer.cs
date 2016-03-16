using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Timer : MonoBehaviour {

	float timeRemaining = 0.0f; 

	public Text timer; 
	
	// Update is called once per frame
	void Update() {
		timeRemaining -= Time.deltaTime; //count down timeRemaining upon start

		timer.text = timeRemaining.ToString ("0"); //display timer second-per-second
				
		if (timeRemaining < 0) {
			Application.LoadLevel(0); //when timer reaches zero, load spash plaige
		}

		if (Application.loadedLevel == 0) {
			timeRemaining = 300.0f; //set initial time
		}
	}
}
