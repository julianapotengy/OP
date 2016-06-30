using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	private GameObject player;
	private GameObject stand;

    private Rigidbody2D rg2d;
    private float fallDelay;

	private int points;
	private bool canScore;
	
	void Start () 
	{
		this.player = GameObject.Find("Player");
		this.stand = this.gameObject;

        this.rg2d = GetComponent<Rigidbody2D>();
        this.fallDelay = 0.1f;
		
		this.canScore = true;
	}
	
	void Update () 
	{
		if (this.stand.transform.position.y >= player.transform.position.y)
			this.stand.GetComponent<BoxCollider2D>().isTrigger = true;
		
		if(this.stand.transform.position.y <= player.transform.position.y)
			this.stand.GetComponent<BoxCollider2D>().isTrigger = false;
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.name.Equals("Player") && canScore)
		{
			this.canScore = false;
            this.player.GetComponent<Player>().AcessPoints += 1;
			Score(c.gameObject.GetComponent<Player>());
            StartCoroutine(Fall());
		}

        if (c.gameObject.name.Equals("Ground"))
        {
            Destroy(this.gameObject);
        }
	}
	
	void Score(Player p)
	{
		p.AcessPoints = 1;
	}

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rg2d.isKinematic = false;
        GetComponent<BoxCollider2D>().isTrigger = true;
        yield return 0;
    }
}
