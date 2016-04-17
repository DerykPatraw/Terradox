using UnityEngine;
using System.Collections;
//Allows man in white to follow you.
public class aiFollow : MonoBehaviour {

	Transform tr_Player;
	float f_RotSpeed=7.0f,f_MoveSpeed = 7.0f;
    public GameObject DeathCanvas;


    // Use this for initialization
    void Start () {

		tr_Player = GameObject.FindGameObjectWithTag ("Player").transform; }

	// Update is called once per frame
	void Update () {
		/* Look at Player*/
		transform.rotation = Quaternion.Slerp (transform.rotation , Quaternion.LookRotation (tr_Player.position - transform.position) , f_RotSpeed * Time.deltaTime);

		/* Move at Player*/
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}
	void OnTriggerEnter(Collider col) {
		if(col.GetComponent<Collider>().tag == "Player")
		{
			DeathCanvas.GetComponent<GameOverScript>().GameOver();
			//Instantiate(DeathCanvas);
			//Application.LoadLevel (0);
		}
	}
}
