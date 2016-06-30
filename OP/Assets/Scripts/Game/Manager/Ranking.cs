﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Ranking : MonoBehaviour {
	
	public List<int> highscores;
	
	public Text highScoreText;
	public Text highScoreText2;
	public Text highScoreText3;
	public Text highScoreText4;
	public Text highScoreText5;
	
	public GameObject player;
	
	void Start () 
	{
		for (int i = 0; i < 5; i++)
		{
			if (!PlayerPrefs.HasKey("SCOREPOSITION " + i))
			{
				PlayerPrefs.SetInt("SCOREPOSITION " + i, 0);
			}
		}
		
		highscores = new List<int>();
		
		for (int g = 0; g < 5; g++)
		{
			highscores.Add(PlayerPrefs.GetInt("SCOREPOSITION " + g));
			
			highscores.Sort();
			highscores.Reverse();
		}
		
		SetHighScore();
	}
	
	void Update () 
	{
		for (int j = 0; j < 5; j++)
		{
			PlayerPrefs.SetInt("SCOREPOSITION " + j, highscores[j]);
		}
		
		if (highscores.Count > 5)
		{
			highscores.Remove(highscores.Min());
		}
		
		highScoreText.text = "Highscore is: " + PlayerPrefs.GetInt("SCOREPOSITION 0");
		highScoreText2.text = "2o: " + PlayerPrefs.GetInt("SCOREPOSITION 1");
		highScoreText3.text = "3o: " + PlayerPrefs.GetInt("SCOREPOSITION 2");
		highScoreText4.text = "4o: " + PlayerPrefs.GetInt("SCOREPOSITION 3");
		highScoreText5.text = "5o: " + PlayerPrefs.GetInt("SCOREPOSITION 4");
	}
	
	protected virtual void SetHighScore()
	{
			highscores.Add(PlayerPrefs.GetInt("SCORE"));
			
			highscores.Sort();
			highscores.Reverse();
	}
}
