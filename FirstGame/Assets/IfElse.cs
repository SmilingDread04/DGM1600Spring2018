using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {

	public bool Key;
	public int Health = 100;
	public string Password = OU812;

	void Start () {
		if (Key)
		{
			print("I have the key.");
		} else
		{
			print("You shall not pass!");
		}

		if (Health >0)
		{
			print("Can play.");
		}
		else
		{
			print("You're dead!");
		}

		if(Password == "OU812")
		{
			print("That's correct");
		}
		else
		{
			print("Try again.");
		}
	}
}