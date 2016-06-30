using UnityEngine;
using System.Collections;

public class RdmStand : MonoBehaviour {

	public GameObject prefab;
    public GameObject prefab2;

    private int randomStand;

    private Vector2 screenSize;

	void Start ()
	{
        this.screenSize.y = GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize;
        this.screenSize.x = this.screenSize.y * GameObject.Find("Main Camera").GetComponent<Camera>().aspect;

        for (int i = 1; i < 100; i++)
        {
            //Instantiate(prefab, new Vector3(Random.Range(-this.screenSize.x, this.screenSize.x),
              //           i * 2, 0), Quaternion.identity);

            if (i >= 30)
            {
                randomStand = Random.Range(0, 11);
                if (randomStand <= 1)
                {
                    Instantiate(prefab2, new Vector3(Random.Range(-this.screenSize.x, this.screenSize.x),
                         i * 2, 0), Quaternion.identity);
                }
                else
                    Instantiate(prefab, new Vector3(Random.Range(-this.screenSize.x, this.screenSize.x),
                         i * 2, 0), Quaternion.identity);
            }
            else
                Instantiate(prefab, new Vector3(Random.Range(-this.screenSize.x, this.screenSize.x), i * 2, 0), Quaternion.identity);

        }
	}

	void Update ()
	{
		
	}
}
