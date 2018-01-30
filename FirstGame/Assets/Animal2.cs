using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal2 : MonoBehaviour {

	public string Name;
	public int foodCount;

	public Text myUIText;

	void OnMouseDown()
	{
		if (1 + 2 == 3)
		{
			print(3);
		}

		if (1 + 2 != 6)
		{
			print("Not 6");
		}

		if (foodCount == 0)
		{
			print("The pet has no food.");
		}

		if (foodCount != 0)
		{
			print("The " + Name + " has " + foodCount + " food.");
		}
	//When an "if" statement is made, the "myUIText" will not work because it is not connected to the "GUI" anymore, and as such can not reference it.
	//If "NullReferenceException: Object reference not set to an instance of an object" shows up, delete the the .text file, like the one shown below.
		myUIText.text = "I have a " + Name + ", it has this amount of food: " + foodCount;
	}

}
