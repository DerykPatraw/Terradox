using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
    Animator anim;

   void Awake() {
        anim = GetComponent<Animator>();
   }
	
	// Update is called once per frame
	void Update () {
			anim.SetTrigger ("GameOver");

		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel (1);
		}
	}
}
