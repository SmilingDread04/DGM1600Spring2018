using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolInput : MonoBehaviour 
{

	public string InputName;
	public float FloatValue = 1;

	public override float SetFloat()
	{
		return Input.GetButton(InputName) ? FloatValue : 0;
	}

}
