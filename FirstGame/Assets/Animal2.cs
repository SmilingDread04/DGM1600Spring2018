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
		myUIText.text = "I have a " + Name + ", it has this amount of food: " + foodCount;
	}

}
