using UnityEngine;
using System.Collections;

public class InstCoin : MonoBehaviour 
{
    public GameObject prefabCoins;
    public GameObject player;

    private Vector2 screenSize;
	
	void Start () 
    {
        this.screenSize.y = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
        this.screenSize.x = this.screenSize.y * GameObject.Find("Main Camera").GetComponent<Camera>().aspect;

        this.player = GameObject.Find("Player");

        /*for (int i = 0; i < Random.Range(10, 41); i++)
        {
            Instantiate(prefabCoins, new Vector3(Random.Range(-this.screenSize.x, this.screenSize.x), i * (Random.Range(6,12)), 0), Quaternion.identity);
        }*/
	}

    void Update()
    {
        int counter = Random.Range(0, 2000);

        if(counter <= 10)
        {
             Instantiate(prefabCoins, new Vector3(Random.Range(-this.screenSize.x, this.screenSize.x), player.transform.position.y + (screenSize.y * 3), 0), Quaternion.identity);
        }
    }
}
