using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {

// Based on what I've learned from class, the Else clause is essentially a more complex version of the If clause's alternate option (I.E.
// if it starts as "if ___ is true", it would represent the false statement).  Essentially, from what I've seen, the else clause is an
// option that can apply if a certain criteria is met.  See, for example, the strings created below:
	public bool Key;
	public int Health = 100;
	public string Password = "OU812";

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
		
// Despite this, much like the regular If clause, the catch is that you will have to add each public condition for every single
// situation; be it a Key, NPC, etc.  For a few more examples, check below:
	
// Example 1: Ghost
	public bool Ghost;

	void attacks () {
		if(Ghost) 
		{
			print("It seems that physical attacks will not work.  Try using magic!");
		}
		else 
		{
			print("That is not a ghost.  Don't believe me?  Then poke 'em, you'll be sorry!");
		}
	}

// Example 2: Stamina
	public int Stamina = 150;
	
	void Reset ()
	{
		if(Stamina > 30)
		{
			print("Be careful!  You only have " + Stamina + " left!");
		}
		else 
		{
			print("You still have " + Stamina + " left, so sprint away!");
		}	
	}

// Example 3: Map
	public bool Map;

	void check () {
		if(Map)
		{
			print("Press L3 to open up the world map.");
		}
		else 
		{
			print("This feature is currently unavailable.");
		}
			 
	}
		     
// Example 4: Hammer
	public bool Hammer;

	void Weapon () {
		if (Hammer)
		{
			print("A weapon type capable of destroying shields and dealing heavy damage.");
		}
		else 
		{
			print("This weapon is not a hammer, so just sell it on eBay, seriously.");
		}
	}
		
			      
// Example 5: Xbox
	public bool Xbox;
	void Currently () {
		if (Xbox)
		{
			print("I like to play my Xbox, I love to play 360!");
		}
		else 
		{
			print("...Buy and Xbox.");
		}
	}
}
