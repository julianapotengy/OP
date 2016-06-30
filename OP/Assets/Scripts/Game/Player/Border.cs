using UnityEngine;
using System.Collections;

public class Border : MonoBehaviour
{
    private Vector2 screenSize;
	
	void Start ()
	{
        this.screenSize.y = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
        this.screenSize.x = this.screenSize.y * GameObject.Find("Main Camera").GetComponent<Camera>().aspect;
	}

	void Update ()
	{
		Limits ();
	}

	void Limits()
	{
        if (this.transform.position.x > screenSize.x)
            this.transform.position = new Vector2(-screenSize.x, this.transform.position.y);
            

        if (this.transform.position.x < -(screenSize.x))
            this.transform.position = new Vector2(screenSize.x, this.transform.position.y);
	}
}
