using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;

    //private GameObject cameraPosition;

	private GameObject player;

	private bool gameReallyStart;
    public  bool gameOver;

	private int counter;
	private float velocityToDetach;

	void Start ()
	{
		this.player = GameObject.Find("Player");

        //cameraPosition = GameObject.Find("Main Camera");

		this.gameReallyStart = false;
        this.gameOver = false;
		
        this.counter = 0;
		this.velocityToDetach = 8.3f;
	}

	void FixedUpdate ()
	{
    	LockCamera ();
        GameOver();

		if (player.GetComponent<Rigidbody2D>().velocity.y >= 0)
		{
			this.counter++;
			
			if (counter >= 5)
				this.gameReallyStart = true;
		}
	}

    private void GameOver()
    {
        if (player.GetComponent<Rigidbody2D>().velocity.y <= -(velocityToDetach) && gameReallyStart == true)
		{
			transform.parent = null;
            this.gameOver = true;
		}
    }

	private void LockCamera()
	{
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
		                                 Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
		                                 Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
	}
}
