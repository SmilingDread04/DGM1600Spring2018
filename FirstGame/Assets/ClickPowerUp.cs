﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUp : MonoBehaviour {

	public PowerUp MyPowerUp;
	private void OnMouseDown()
	{
		MyPowerUp.RunPowerUp();
	}
}
