using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {

// Based on what I learned in class, For Loops/Foreach Loops are an expansion of the Loops concept, combining elements of the loop string
// and If-Else Clause to create a "simplified" version for triggering key events, like toggling through different commands as seen below:
	
	public string[] Keys;
	public string[] Names;
	public string[] Apples;
	public string[] Weapons;
	public string[] Items;
	public string[] Crafting;
	public string[] Gears;
	public string[] Players;
	public string[] Costumes;
	public string[] Cards;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < Keys.Length; i++)
		{
			if (Keys[i] == "Add Ammo") 
			{
				print(Keys[i]);
			}
		}

		foreach (var Name in Names)
		{
			print(Name);
		}
		
		for (int i = 0; i < Apples.Length; i++)
		{
			print(Apples[i]);
		}
		
		foreach (var Gear in Gears)
		{
			print(Gear);
		}
		
		for (int i = 0; i < Crafting.Length; i++)
		{
			print(Crafting[i]);
		}
		
		foreach (var Weapon in Weapons)
		{
			print(Weapon);
		}
		
		for (int i = 0; i < Players.Length; i++)
		{
			print(Players[i]);
		}
		
		foreach (var Item in Items)
		{
			print(Item);
		}
		
		for (int i = 0; i < Cards.Length; i++)
		{
			print(Cards[i]);
		}
		
		foreach (var Costume in Costumes)
		{
			print(Costumes);
		}
	}

	void Run() 
	{

	}

}
