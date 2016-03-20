using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Timer : MonoBehaviour {

	static float timeRemaining = 10.0f; 

	public Text timer; 

	// Update is called once per frame
	void Update() {
		
		timeRemaining -= Time.deltaTime; //count down timeRemaining upon start

		if (timeRemaining < 0) { //when timer reaches zero...
			//Application.LoadLevel (0); //load spash plaige
			timer.text = ("He's Coming."); //display message, stop timer display
		} 

		else {
			timer.text = timeRemaining.ToString ("0"); //display timer second-per-second
		}

		if (Application.loadedLevel == 0) {
			timeRemaining = 10.0f; //set initial time (in seconds)
		}
	}
}