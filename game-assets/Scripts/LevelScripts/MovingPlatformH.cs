using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformH : MonoBehaviour {

    public float posR = 4f;
    public float posL = -4f;
    float dirX;
    public float moveSpeed = 3f;
	bool moveRight = true;

	// Update is called once per frame
	void Update () {
		if (transform.position.x > posR)
			moveRight = false;
		if (transform.position.x < posL)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}
