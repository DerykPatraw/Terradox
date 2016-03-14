using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Timer : MonoBehaviour {

	float timeRemaining; //number that counts down
	string timeLeft; //what user sees

	public Text text;
	
	// Update is called once per frame
	void Update() {
		timeRemaining -= Time.deltaTime; //count down timeRemaining upon start
		timeLeft = string.Format("{0:0.0}", timeRemaining); //Show user the time 
		print(timeLeft); //show how much time is remaining

		text.text = timeLeft; //display time on screen
				
		if (timeRemaining < 0) {
			Application.LoadLevel(0); //when timer reaches zero, load spash plaige
		}

		if (Application.loadedLevel == 0) {
			timeRemaining = 650.0f; //set initial time
		}
	}
}
