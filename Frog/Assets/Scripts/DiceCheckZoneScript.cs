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
		string index = col.gameObject.tag;
		int where = -1;
        switch (index)
        {
			case "one":
				where = 0;
				break;
			case "two":
				where = 1;
				break;
			case "three":
				where = 2;
				break;
			case "four":
				where = 3;
				break;
			case "five":
				where = 4;
				break;
        }
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			DiceNumberTextScript.count++;
			switch (col.gameObject.name) {
			case "Side1":
				DiceNumberTextScript.array[where] = 6;
				break;
			case "Side2":
				DiceNumberTextScript.array[where] = 5;
				break;
			case "Side3":
				DiceNumberTextScript.array[where] = 4;
				break;
			case "Side4":
				DiceNumberTextScript.array[where] = 3;
				break;
			case "Side5":
				DiceNumberTextScript.array[where] = 2;
				break;
			case "Side6":
				DiceNumberTextScript.array[where] = 1;
				break;
			}
			GetComponent<DiceCheckZoneScript>().enabled = false;
		}
	}
}
