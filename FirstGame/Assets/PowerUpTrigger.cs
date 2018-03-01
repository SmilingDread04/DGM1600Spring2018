﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp MyPowerUp;
	public Player MyPlayer;

	private void OnTriggerEnter()
	{
		AddPower(MyPowerUp);
	}

	private void OnTriggerExit()
	{
		print(PowerLevel);
	}

	void AddPower(PowerUp powerUp)
	{
		print(powerUp.PowerLevel);
		MyPlayer.Health += MyPowerUp.PowerLevel;
	}
}
