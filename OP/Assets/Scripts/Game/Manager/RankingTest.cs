using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class RankingTest : MonoBehaviour {

    List<int> highscores;
    private int maxScore;

    public Text highScoreText;
    public Text highScoreText2;

  	void Start () 
    {
        highScoreText = GameObject.Find("MyText").GetComponent<Text>();
        highScoreText2 = GameObject.Find("MyText2").GetComponent<Text>();

        //highScoreText.transform.position = new Vector3(Screen.width / 4, Screen.height / 1.2f, 0);

	    highscores = new List<int>();

        highscores.Add(1);
        highscores.Add(3);
        highscores.Add(0);
        highscores.Add(2);

        highscores.Sort();
        highscores.Reverse();

        foreach (int highscore in highscores)
        {
            print(highscore);
        }
	}
	
	void Update () 
    {
        this.maxScore = highscores.Max();

        highScoreText.text = "Highscore is: " + maxScore;
        highScoreText2.text = "2o: " + highscores[1];
	}

    public void AddValues()
    {
        highscores.Add(maxScore + Random.Range(-9,9));
    }

    public void ShowValues()
    {
        foreach (int highscore in highscores)
        {
            print(highscore);
        }
    }

    public void SortValues()
    {
        highscores.Sort();
        highscores.Reverse();
    }

    
}
