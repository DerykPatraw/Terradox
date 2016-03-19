using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Used for loading levels
	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}
}