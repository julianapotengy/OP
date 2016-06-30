using UnityEngine;
using System.Collections;

public class InstJumpForce2x : MonoBehaviour
{
	public GameObject prefabJumpForce2x;
	
	private Vector2 screenSize;
	
	void Start () 
	{
		this.screenSize.y = GameObject.Find ("Main Camera").GetComponent<Camera> ().orthographicSize;
		this.screenSize.x = this.screenSize.y * GameObject.Find ("Main Camera").GetComponent<Camera> ().aspect;
		
		for (int i = 1; i < Random.Range(1, 4); i++)
		{
			Instantiate (prefabJumpForce2x, new Vector3 (Random.Range (-this.screenSize.x, this.screenSize.x), i * (Random.Range (5, 20)), 0), Quaternion.identity);
		}
	}
}
