using UnityEngine;	
using System.Collections;

public class Player : MonoBehaviour 
{
	protected float jumpForce;
	public AudioClip jumpSound;
	protected AudioSource jump;

	protected float lockPos;
	
	protected CameraFollow cameraFollow;

	public bool addCoins;
	public bool bonusCoins;
	protected int price;

	public bool setHighscore;
	private int points;

	protected void Start () 
	{
		this.jumpForce = 400;
		this.jump = GetComponent<AudioSource> ();

		this.points = 0;
		setHighscore = false;

		this.lockPos = 0;

		this.bonusCoins = false;
		
		this.cameraFollow = GameObject.Find("Main Camera").GetComponent<CameraFollow>();
		
		if (!PlayerPrefs.HasKey("SCORE"))
			PlayerPrefs.SetInt("SCORE", 0);
	}
	
	protected void Update () 
	{
		if (this.cameraFollow.gameOver)
		{
			Debug.Log(this.points);
			SetHighScore();
		}

		Debug.Log (this.points);
		transform.rotation = Quaternion.Euler (this.lockPos, this.lockPos, this.lockPos);
	}

	public int AcessPoints
	{
		get { return this.points; }
		set {
			if (value == 1)
				this.points += value;
		}
	}

	protected void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.name.Equals ("Ground") || c.gameObject.name.Equals ("Stand") ||
			c.gameObject.name.Equals ("Stand(Clone)") || c.gameObject.name.Equals ("MoveStand(Clone)"))
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce));
			jump.PlayOneShot(jumpSound, 10f);
		}

		if (c.gameObject.name.Equals ("jumpForce2x(Clone)"))
		{
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce * 2));
			Destroy (c.gameObject);
			jump.PlayOneShot(jumpSound, 10f);
		}
	}
	
	protected void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.name.Equals("Coin(Clone)"))
		{
			this.addCoins = true;
			Destroy(c.gameObject);
		}
	}

	protected void SetHighScore()
	{
		PlayerPrefs.SetInt("SCORE", this.points);
		setHighscore = true;
		Application.LoadLevel("Ranking");
	}

	public int AccessPrice2
	{
		get { return this.price; }
	}
}

