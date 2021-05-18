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
		array.Clear();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
			array.Clear();
        }
			if (diceNumber != 0)
        {
			array.Add(diceNumber);
			diceNumber = 0;
			Debug.Log(array.Count);
		}
        if (array.Count > 4)
        {
			Debug.Log(array[0]+" "+ array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " ");
        }
		//Scoretext.text ="Your Score: "+ diceNumber.ToString();
	}
	void DisplayScore()
    {

    }
}
