using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextsOnGame : MonoBehaviour
{
	public Text coins;
	public Text score;

	private Player player;

	void Start ()
	{
		this.player = GameObject.Find ("Player").GetComponent<Player> ();
	}

	void Update ()
	{
		coins.text = "COINS: " + PlayerPrefs.GetInt ("COINS");
		score.text = "SCORE: " + player.AcessPoints;
	}
}