using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hideMouse : MonoBehaviour {

	bool CursorLockedVar;
	bool pause;
	//Set's the cursor to be invisible and locked
		void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		CursorLockedVar = (true);
		Time.timeScale = 1;
		AudioListener.pause = (false);
	}
	//Every update, check if user has pressed escape and if the pause variable is already assigned
	void Update ()
	{
		if (Input.GetKeyDown ("escape") && !CursorLockedVar) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = (false);
			CursorLockedVar = (true);
			Time.timeScale = 1;
			AudioListener.pause = (false);
		}

		//Every update, check if user has pressed escape and if the pause variable is already assigned
		else if(Input.GetKeyDown("escape") && CursorLockedVar){
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = (true);
			CursorLockedVar = (false);
			Time.timeScale = 0;
			AudioListener.pause = (true);
		}

		else if(Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl) && Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
	}
} 