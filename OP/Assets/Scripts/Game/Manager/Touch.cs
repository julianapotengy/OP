using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour
{
	private Player player;
	private Vector3 middle;
	public bool normalTouch;
	
	void Start()
	{
		this.player = GameObject.Find("Player").GetComponent<Player>();
		this.middle = new Vector3(Screen.width/2, 0, 0);
		this.normalTouch = true;
	}
	
	void Update()
	{
		Move();
	}
	
	protected virtual void Move() 
	{
		if (normalTouch == true)
		{
			if (Input.GetMouseButton (0))
			{
				if (Input.mousePosition.x >= middle.x)
					player.transform.position += new Vector3 (0.1f, 0, 0);
				
				if (Input.mousePosition.x < middle.x)
					player.transform.position += new Vector3 (-0.1f, 0, 0);
			}
		}
		if (normalTouch == false)
		{
			if (Input.GetMouseButton (0))
			{
				if (Input.mousePosition.x >= middle.x)
					player.transform.position += new Vector3 (-0.1f, 0, 0);
				
				if (Input.mousePosition.x < middle.x)
					player.transform.position += new Vector3 (0.1f, 0, 0);
			}
		}
	}
}