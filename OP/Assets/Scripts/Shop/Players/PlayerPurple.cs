using UnityEngine;
using System.Collections;

public class PlayerPurple : Player
{
	void Start ()
	{
		this.price = 1;
		//this.price = 1000;

		// jumpForce x 2 e coins em dobro
		this.jumpForce *= 2;
		this.bonusCoins = true;

		//base.Start();
	}

	void Update ()
	{
		//base.Update();
	}
}
