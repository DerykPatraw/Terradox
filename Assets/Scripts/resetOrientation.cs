﻿using UnityEngine;
using System.Collections;
using UnityEngine.VR;
//Resets oculus
public class Example : MonoBehaviour {

	void Start () {
		UnityEngine.VR.InputTracking.Recenter();
	}

	void Update () {
		if (Input.GetKey(KeyCode.F12))
		{
			UnityEngine.VR.InputTracking.Recenter();
		}
	}
}