using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp MyPowerUp;
	public Player MyPlayer;
	//public Health MyHealth;

	private void OnTriggerEnter(Collider Player)
	{
	
		{
			//AddPower(MyPowerUp);
		}

		{
			//AddPower(MyHealth);
		}
	}
	

	private void OnTriggerExit(Collider Player)
	{
		{
			//print(PowerLevel);
		}

		{
			//print(HealthBar);
		}
	}
	

	void AddPower(PowerUp powerUp)
	{
		//print(powerUp.PowerLevel);
		//MyPlayer.Health += MyPowerUp.PowerLevel;
	}
}
