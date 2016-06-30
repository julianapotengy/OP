using UnityEngine;
using System.Collections;

public class PlayerGreen : Player
{
	void Start ()
	{
		this.price = 1;
		//this.price = 200;

		// jumpForce x 2.0
		this.jumpForce *= 2;
		this.bonusCoins = false;

		//base.Start();
	}

	void Update ()
	{
		//base.Update();
	}
}
