using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {

	public int A;
	public int B;
	public int Heart;
	public int Health;
	public string Password = "Love";

	// Use this for initialization
	void Start () {
		if (A > B && Password == "Love")
		{
			print("Greater");
		}

		if (Password == "love" || Password == "Love" || Password == "LOVE")
		{
			Heart = 100;
			Health += 10;
		}
	}
}
