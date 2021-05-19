using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceNumberTextScript : MonoBehaviour {

	public TextMeshProUGUI Scoretext;
	public static int diceNumber;
	public static int[] array;
	public static int count;

	// Use this for initialization
	void Start () {
		Scoretext.text = "Your Score: ";
		array = new int[5];
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
			array = new int[5];
        }
		/*if (diceNumber != 0)
        {
			array.Add(diceNumber);
			diceNumber = 0;
			Debug.Log(array.Count);
		}*/
        if (count > 4)
        {
			//Debug.Log(array[0]+" "+ array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " ");
			//array.Clear();
        }
		//Scoretext.text ="Your Score: "+ diceNumber.ToString();
	}
	void DisplayScore()
    {

    }
}
