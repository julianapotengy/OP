using UnityEngine;
using System.Collections;

public class ChangeTouch : MonoBehaviour
{
	private GameObject touch;
	//private GameObject powerUp;
	
	void Start ()
	{
		this.touch = GameObject.Find ("Touch");
		//this.powerUp = this.gameObject;
	}
	
	void Update ()
	{
		
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.name.Equals("Player"))
		{
			touch.GetComponent<Touch>().normalTouch = false;
			Destroy(this.gameObject);
		}
	}
}
