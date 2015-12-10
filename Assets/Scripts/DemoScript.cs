using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {

	public Light myLight;

	//Update() runs this command every single frame. Constant update checking.
	void Update () {
		if (Input.GetKeyDown ("f")) {
			myLight.enabled = !myLight.enabled;
		}
	}
/*
	Awake()
	Start()
	Update ()
	FixedUpdate()
	LateUpdate()
*/
}