using UnityEngine;
using System.Collections;

public class PlayerOrange : Player
{
	void Start ()
	{
		this.price = 1;
		//this.price = 400

		// coins em dobro
		this.bonusCoins = true;

		//base.Start();
	}

	void Update ()
	{
		//base.Update();
	}
}
