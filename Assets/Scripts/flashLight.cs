using UnityEngine;
using System.Collections;
//Toggleable flashlight
public class flashLight : MonoBehaviour {

	public Light myLight;

	void Start () {
		myLight.enabled = !myLight.enabled;
	}
	void Update () {
		if (Input.GetKeyDown("f")){
			myLight.enabled = !myLight.enabled;
		}
	}
}

