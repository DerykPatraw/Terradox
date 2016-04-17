using UnityEngine;
using System.Collections;
//Calls 'death' animation and scene return
public class GameOverScript : MonoBehaviour {
    Animator anim;
	public GameObject Player;
	public GameObject SpawnTimer;
	public static int Active = 0;

   void Awake() {
        anim = GetComponent<Animator>();
   }
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 1) {
			Active = 0;
		}

		if (Input.GetKey (KeyCode.Return) && Active == 1) { //if death screen appears, press enter to go to credits scene
			Destroy(Player); //destroy player object before credits scene(to fix bugs)
			Destroy(SpawnTimer); //destroy the SpawnTimer object before credits scene (to fix bugs)
			Application.LoadLevel (10);
		}
		if (Active == 1) { //if active is set to 1, make death screen appear
			anim.SetTrigger ("GameOver");
		}
	}

	public void GameOver() {
		Active = 1; 
	}
}
