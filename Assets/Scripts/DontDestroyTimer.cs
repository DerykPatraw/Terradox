using UnityEngine;
using System.Collections;

public class DontDestroyTimer : MonoBehaviour {

	void Awake () {
		DontDestroyOnLoad (transform.gameObject); //don't destroy timer object upon entering new level
		}
	}


