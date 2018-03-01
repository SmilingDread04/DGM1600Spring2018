using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

// Switch statements are, from what I've noticed, a simpler version of the if-else clause, allowing a program to run quicker without
// needing to run every possible scenario.  Of every possible lesson, this is by far the most interesting, as I can see how this can
// apply to any kind of program, such as the ones stated below:
	
	public string UserName;
	public string ItemBuy;

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
				
			case "JusticeLeague":
				print("...You have no good soul...");
				break;

			default:
				// do work
				print("Why don't you just tell me which movie you want to see?");
				break;
		}
			

		switch (ItemBuy)
		{
			case "HealthUp":
				print("Your health gauge has increased by 100 points!");
				break;
			
			case "Hammer":
				print("Have fun smashing brains in!");
				break;
				
			case "Sword":
				print("So sharp and pointy!");
				break;
				      
			case "AmmoPouch":
				print("Your ammo count has increased by 100 slots!");
				break;
			
		}
	}
	
}
