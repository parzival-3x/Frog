using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name) {
			case "Side1":
				DiceNumberTextScript.diceNumber += 0;
				break;
			case "Side2":
				DiceNumberTextScript.diceNumber += 50;
				break;
			case "Side3":
				DiceNumberTextScript.diceNumber += 0;
				break;
			case "Side4":
				DiceNumberTextScript.diceNumber += 0;
				break;
			case "Side5":
				DiceNumberTextScript.diceNumber += 0;
				break;
			case "Side6":
				DiceNumberTextScript.diceNumber += 100;
				break;
			}
		}
	}
}
