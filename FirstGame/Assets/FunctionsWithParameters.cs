using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour 
{
	public int b;
	public int Health = 20;

// int MyInt; = Collider other 

// Collidor other;

	void OnTriggerEnter(Collider other)
	{
		print("Do something");
		print(other);

		AddNumbers(14, 2);
		AddHealth(25);
		PlayerData("Bob");
	}

	void AddNumbers(int a, int b)
	{
		print(a += b);	
	}

	void PlayerData(string name)
	{
		print ("This player is " + name);
	}

	void AddHealth(int newHealth)
	{
		Health += newHealth;
	}

}

