﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hideMouse : MonoBehaviour {

	bool CursorLockedVar;
	
	void Start ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		CursorLockedVar = (true);
	}
	
	void Update ()
	{
		if (Input.GetKeyDown ("escape") && !CursorLockedVar) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = (false);
			CursorLockedVar = (true);
		}
		else if(Input.GetKeyDown("escape") && CursorLockedVar){
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = (true);
			CursorLockedVar = (false);
		}
	}
}