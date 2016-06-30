using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyPlayer : MonoBehaviour 
{
	//private Player player;
	private int buyCash;
	private int price;
	private int playerChoosed;
	private GameObject clicked;
	//public Text coinsText;
	
	void Start () 
	{
		//player = GameObject.FindObjectOfType<Player> ().GetComponent<Player> ();
		buyCash = PlayerPrefs.GetInt ("COINS");
		//coinsText = Text.FindObjectOfType<Coins> ().GetComponent<Text> ();
	}
	
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hitInfo = new RaycastHit();
			
			if (Physics.Raycast (ray, out hitInfo, 100)) 
			{
				this.price = hitInfo.collider.gameObject.GetComponent<Player>().AccessPrice2;
				
				if (hitInfo.collider.gameObject.name == "PlayerBlue")
					this.playerChoosed = 1;
				
				else if (hitInfo.collider.gameObject.name == "PlayerGreen")
					this.playerChoosed = 2;

				else if (hitInfo.collider.gameObject.name == "PlayerOrange")
					this.playerChoosed = 3;

				else if (hitInfo.collider.gameObject.name == "PlayerPurple")
					this.playerChoosed = 4;
				
				Debug.Log(this.price);
				Buy();
			}
		}
	}

	void Buy()
	{
		if (this.buyCash >= this.price) 
		{
			this.buyCash = (this.buyCash - this.price);
			
			//PlayerPrefs.SetInt("Player", playerChoosed);
			PlayerPrefs.SetInt("COINS", this.buyCash);
			
			Debug.Log("COINS: " + this.buyCash);
			//coinsText.text = "oi";
			
		} else
			Debug.Log ("Bitch better have my money");
	}
	
	public int AccessCoins
	{
		get { return this.buyCash; }
	}

}