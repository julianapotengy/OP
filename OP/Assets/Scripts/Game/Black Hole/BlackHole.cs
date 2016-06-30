using UnityEngine;
using System.Collections;

public class BlackHole : MonoBehaviour
{
	public GameObject prefabBlackHole;
	
	private Vector2 screenSize;
	
	void Start () 
	{
		this.screenSize.y = GameObject.Find ("Main Camera").GetComponent<Camera> ().orthographicSize;
		this.screenSize.x = this.screenSize.y * GameObject.Find ("Main Camera").GetComponent<Camera> ().aspect;
		
		for (int i = 1; i < Random.Range(1, 3); i++)
		{
			Instantiate (prefabBlackHole, new Vector3 (Random.Range (-this.screenSize.x, this.screenSize.x),
			                                           i * (Random.Range (25, 50)), 0), Quaternion.identity);
		}
	}
	
	void Update ()
	{
		
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.name.Equals("Player"))
		{
			Application.LoadLevel("Game");
		}
	}
}
