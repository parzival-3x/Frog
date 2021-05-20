using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;
	public float x;
	public static bool isStill;
	private bool gameStarted = false;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		diceVelocity = rb.velocity;
		isStill = diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f && gameStarted;

		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceNumberTextScript.array= array = new int[5];
			gameStarted = true;
			GetComponent<DiceCheckZoneScript>().enabled = true;
			DiceNumberTextScript.diceNumber = 0;
			float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);
			//Debug.Log(dirX + " " + dirY + " " + dirZ);
			transform.position = new Vector3 (0, 5, 0);
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * 500);
			rb.AddTorque (dirX, dirY, dirZ);
		}
	}
}
