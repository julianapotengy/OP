using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    private int coins;
    private Player player;

	void Start () 
    {
        if (!PlayerPrefs.HasKey("COINS"))
        {
            PlayerPrefs.SetInt("COINS", 0);
            Debug.Log("Entrou");
        }

        this.player = GameObject.Find("Player").GetComponent<Player>();

        this.coins = PlayerPrefs.GetInt("COINS");
	}
	
	void Update () 
    {
        AddPoints();
	}

    private void AddPoints()
    {
        if (player.addCoins)
        {
            if (player.bonusCoins == false)
			{
				this.coins = (PlayerPrefs.GetInt("COINS") + 1);
			}
			else if (player.bonusCoins == true)
			{
				this.coins = (PlayerPrefs.GetInt("COINS") + 2);
			}

            PlayerPrefs.SetInt("COINS", this.coins);
            player.addCoins = false;
            Debug.Log(PlayerPrefs.GetInt("COINS"));
        }
    }
}
