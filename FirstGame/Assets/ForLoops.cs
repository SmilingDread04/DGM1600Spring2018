using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {

	public string[] Keys;
	public string[] Names;

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
	}

	void Run() 
	{

	}

}
