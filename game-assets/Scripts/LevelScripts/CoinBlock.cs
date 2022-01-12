using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBlock : MonoBehaviour {
	private GameObject child;
	public int totalCoins;
	public Sprite disabled;
	public coinCounter coinCounter;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col) {

		if (col.collider.bounds.max.y < transform.position.y
			&& col.collider.bounds.min.x < transform.position.x + 0.5f
			&& col.collider.bounds.max.x > transform.position.x -0.5f
			&& col.collider.tag == "Player") {
				if (totalCoins > 0) {
					coinCounter.AddCoin ();
					totalCoins -= 1;
                if (totalCoins == 0)
                    {
                    Destroy(this.gameObject);
                    }
                }
			}
		}
	}
