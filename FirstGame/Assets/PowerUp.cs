﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject 
{
	public int PowerLevel = 10;

	public MovePattern MovePatternTransfer;

	public MovePattern Transfer()
	{
		return MovePatternTransfer;
	}
}
