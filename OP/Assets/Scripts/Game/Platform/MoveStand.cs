using UnityEngine;
using System.Collections;

public class MoveStand : MonoBehaviour {

	float speed;
	private string direction;

    private Vector2 screenSize;

	void Start ()
    {
		speed = 0.05f;
		direction = "right";

        this.screenSize.y = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
        this.screenSize.x = this.screenSize.y * GameObject.Find("Main Camera").GetComponent<Camera>().aspect;
	}

    void Update()
    {
        if (direction.Equals("right"))
            this.transform.Translate(Vector3.right * speed);
        if (direction.Equals("left"))
            this.transform.Translate(Vector3.left * speed);

        if (direction.Equals("right") && transform.position.x > screenSize.x)
            direction = "left";
        if (direction.Equals("left") && transform.position.x < -screenSize.x)
            direction = "right";
    }
}
