using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatInput : InputBase {

	public string InputName;

	public override float SetFloat ()
	{
		return Input.GetAxis(InputName);
	}
}