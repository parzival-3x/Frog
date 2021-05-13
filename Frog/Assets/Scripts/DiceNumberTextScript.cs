using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceNumberTextScript : MonoBehaviour {

	public TextMeshProUGUI Scoretext;
	public static int diceNumber;

	// Use this for initialization
	void Start () {
		Scoretext.text = "Your Score: ";
	}
	
	// Update is called once per frame
	void Update () {
		
		Scoretext.text ="Your Score: "+ diceNumber.ToString();
	}
}
