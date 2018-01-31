using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal3_Bool : MonoBehaviour {

// From what I was taught in class about "if" statements, they are essentially the lightswitches for a program: when set one way, a series of steps
// are executed in order to make it stand out; while, in the other direction, doesn't do anything.  Take for example the statements I've created below:

// Examples 1 & 2: Evil - True or False
	public bool Evil = false;
	
	void OnMouseDown ()
	{
		if(Evil == true) {
			print("I will destroy the world!");
		}
		if(Evil == false)
			print("I will save the world!");
	}
	
// Examples 3 & 4: Cat - True or False
	public bool Cat = false;
	
	void OnMouseDown ()
	{
		if(Cat == true) {
			print("This cat has " + foodCount + " fish." );
		}
		if(Cat == false)
			print("This " + Name + " has 13 food.");
	}
	
// Examples 5 & 6: Door - True or False
	public bool Door = false;
	
	void OnMouseDown ()
	{
		if(Door == true) {
			print("The " + Name + "Door is unlocked for everyone, so please come in!);
		}
		if(Door == false)
			print("This is a " + Name + " you ditz, go play somewhere else!);
	}
	
// Examples 7 & 8: foodCount - Greater or Less than
	public bool foodCount = false;
	
	void OnMouseDown ()
	{
		if(foodCount >= 10) {
			print("This " + Name + " has " + foodCount + " food.");
		}
		if(foodCount <= 10)
			print("This " + Name + " needs 10 food to survive.");
	}
	
// Examples 9 & 10: ??? - True or False
	public bool Evil = false;
	
	void OnMouseDown ()
	{
		if(??? == true) {
			print("You wanna get hiiiigh... on Marioshrooms?");
		}
		if(??? == false)
			print("You wanna get hiiiigh...?  Well, then go watch South Park, you dumbass!");
	}
}
