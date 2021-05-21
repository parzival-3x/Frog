using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;
	public float x;
	public bool isStill;
	private bool gameStarted = false;//does the placement matter?
	public bool isStop;
	private Vector3 lastV;
	public bool notMoving;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		lastV = rb.velocity;
	}
	
	// Update is called once per frame
	void Update () {
		diceVelocity = rb.velocity;
		Vector3 accel = (diceVelocity - lastV) / Time.deltaTime;
		lastV = diceVelocity;
		isStop = accel.x == 0f && accel.y == 0f && accel.z == 0f && gameStarted;
		isStill = diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f && gameStarted;
		notMoving = isStill && isStop;
		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceNumberTextScript.check = true;
			DiceNumberTextScript.array= new int[5];
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
