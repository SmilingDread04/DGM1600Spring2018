using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUp;

	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<MoveCharacter>().MovePattern = PowerUp.MovePattern;
	}
}
