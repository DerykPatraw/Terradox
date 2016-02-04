using UnityEngine;
using System.Collections;

public class aiHitCollider : MonoBehaviour {

	void OnColliderEnter (Collider col)
	{
		if(col.GetComponent<Collider>().name == "CharacterBody")
		{
			Application.LoadLevel(4);
		}
	}
}