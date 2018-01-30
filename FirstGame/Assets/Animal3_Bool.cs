using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal3_Bool : MonoBehaviour {

	public bool Evil = false;
	
	void OnMouseDown ()
	{
		if(Evil == true) {
			print("I will destroy the world!");
		}
		if(Evil == false)
			print("I will save the world!");
	}
}
