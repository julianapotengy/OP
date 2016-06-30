using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinsText : MonoBehaviour
{
	public Text coins;

	void Start ()
	{
		
	}

	void Update ()
	{
		coins.text = "COINS: " + PlayerPrefs.GetInt ("COINS");
	}
}
