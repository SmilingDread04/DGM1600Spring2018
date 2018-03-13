using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Add : Calculation 
{

	public override float Calculate (string a, string b)
	{
		float aNum = float.Parse(a);
		float bNum = float.Parse(b);

		return aNum + bNum;
	}
}
