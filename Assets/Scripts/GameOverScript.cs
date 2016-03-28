using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
    Animator anim;

    void Awake()
   {
        anim = GetComponent<Animator>();
        anim.SetTrigger("GameOver");
   }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			Application.LoadLevel (0);
		}
	}
}
