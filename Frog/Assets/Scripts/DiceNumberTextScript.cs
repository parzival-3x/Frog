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
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	public GameObject five;

	// Use this for initialization
	void Start () {
		Scoretext.text = "Your Score: ";
		array = new int[5];
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown(KeyCode.Space))
        {
			array = new int[5];
        }
		if (diceNumber != 0)
        {
			array.Add(diceNumber);
			diceNumber = 0;
			Debug.Log(array.Count);
		}*/
        if (count > 4)
        {
			if(one.GetComponent<DiceScript>().isStill&& two.GetComponent<DiceScript>().isStill&& three.GetComponent<DiceScript>().isStill&&four.GetComponent<DiceScript>().isStill&& five.GetComponent<DiceScript>().isStill)
            {
				DisplayScore();
            }
			//Debug.Log(array[0]+" "+ array[1] + " " + array[2] + " " + array[3] + " " + array[4] + " ");
			//array.Clear();
        }
		//Scoretext.text ="Your Score: "+ diceNumber.ToString();
	}
	void DisplayScore()
    {
		int score = 0;
		foreach(int i in array)
        {
			if (i == 1)
				score += 100;
			else if (i == 5)
				score += 50;
        }
		Scoretext.text = "Your score: "+score.ToString();
    }
}
