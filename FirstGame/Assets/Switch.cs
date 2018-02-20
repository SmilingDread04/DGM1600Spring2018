using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;


	// Use this for initialization
	void Start () {
		switch (UserName)
		{
			case "Password":
				// do work
				print("Password is correct.");
				break;
				// stops case from running through all possibilities

			case "LevelUp":
				// do work
				print("You win! Next level.");
				break;

			case "BlackPanther":
				print("Made over 200 million this weekend!");
				break;

			default:
				// do work
				print("Why don't you just tell me which movie you want to see?");
				break;



		}
	}
	
}
