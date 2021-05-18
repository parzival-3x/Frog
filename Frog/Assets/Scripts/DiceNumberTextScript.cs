using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceNumberTextScript : MonoBehaviour {

	public TextMeshProUGUI Scoretext;
	public static int diceNumber;
	private ArrayList array = new ArrayList();

	// Use this for initialization
	void Start () {
		Scoretext.text = "Your Score: ";
	}
	
	// Update is called once per frame
	void Update () {
        if (diceNumber != 0)
        {
			array.Add(diceNumber);
			diceNumber = 0;
			Debug.Log(array.Count);
		}
		//Scoretext.text ="Your Score: "+ diceNumber.ToString();
	}
	void DisplayScore()
    {

    }
}
