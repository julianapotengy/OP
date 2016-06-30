using UnityEngine;
using System.Collections;

public class PlayerBlue : Player
{

	void Start ()
	{
		this.price = 1;
		//this.price = 100;

		// jumpForce x 1.5
		this.jumpForce *= 1.5f;
		this.bonusCoins = false;

		//base.Start();
	}

	void Update ()
	{
		//base.Update();
	}
}
