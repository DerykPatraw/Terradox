using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

	Animator anim;
	static float VoiceTimer = 27.0f; //time until animation plays (and dialogue finishes)
	static float Count = 0.0f; //starting time
	static float Finish = 32.0f; //time until moving to next scene

	public 

	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>(); //reference component

	}
	
	// Update is called once per frame
	void Update () {

		Count += Time.deltaTime; //count up
		print (Count);

		//count up until dialogue is finished, then play animation
		if (Count > VoiceTimer) {
			anim.SetTrigger ("StartFade");
		}
		//count up until both animation and dialogue finish, then move to spash plaige
		if (Count > Finish) {
			Application.LoadLevel (1);
		}
	}
}
