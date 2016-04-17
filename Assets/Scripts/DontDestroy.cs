using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Used for loading levels
	void Awake () {
		if (Application.loadedLevel != 10) {
			DontDestroyOnLoad (transform.gameObject);
		}
	}
}