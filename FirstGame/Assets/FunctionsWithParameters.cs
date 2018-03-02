using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParameters : MonoBehaviour

// Parameter-based functions, as I would have expected, are coding strings that work uniquely with different parts of a script, whether
// they be from the coding software's index of commands or simple words implemented by the coder for the sake of filling placeholders,
// such as with the unique coding strings listed down below:

{
	public int b;
	public int Health = 20;

// int MyInt; = Collider other 

// Collidor other;

	void OnTriggerEnter(Collider other)
	{
		print(other + "took damage.");
		print(other);

		AddNumbers(14, 2);
		AddHealth(25);
		PlayerData("Bob");
	}
	
	void OnTriggerExit(Collider other)
	{
		print(other + "is scarred for life...");
		print(Collider + "is a monster!")
	}
	
	void OnBecameVisible ()
	{
		enabled = true
		print("Who's that Pokemon?");
		print("A: Ghastly")
		print("B: Rotom")
		print("C: Magikarp)
	}
	
	void OnBecameInvisible ()
	{
		enabled = false
		print("Iiiit'sss... Not there...  What the hell?")
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
	
	void OnFailedToConnect(NetworkConnectionError error) {
        Debug.Log("...You're a " + other + ", you can't play MOBAs: " + error);
    }

}

