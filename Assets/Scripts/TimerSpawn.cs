using UnityEngine;
using System.Collections;

public class TimerSpawn : MonoBehaviour {

	static float timeRemaining = 1.0f;
	public GameObject ManInWhite;
	public GameObject spawn;

	// Update is called once per frame
	void Update () {

		//check the current state of the man in white
		Debug.Log ("Active Self: " + ManInWhite.activeSelf);
		Debug.Log ("Active Hierarchy: " + ManInWhite.activeInHierarchy);

		//Don't count down in spash plaige
		if (Application.loadedLevel == 1) {
			timeRemaining = 1.0f; //set initial time
		} 

		//count down from initial time
		if (timeRemaining > 0) { 
			timeRemaining -= Time.deltaTime; //count down timeRemaining in seconds
			//print (timeRemaining);
		}

		//spawn ManInWhite on SpawnTimer position (only if there isn't already a man in white)
		else {
			Activate (); //spawn man in white after timer runs out
			print ("Spawn Timer has reached 0");
		}
	}

	void Activate() { //function for determining if man in white should spawn

		spawn = GameObject.FindWithTag("ManInWhite"); //set variable for man in white spawn

		//if no tag for man in white is found, spawn man in white
		if (spawn == null) {
			Instantiate (ManInWhite, transform.position, transform.rotation);
		} 
	}
}
