using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {
	public enum Amount{ one, ten, thirty, fifty }; 
	public Amount type;
	public coinCounter coinCounter;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.name == "player") {
			if (type == Amount.one) {
				coinCounter.AddCoin ();
			} else if (type == Amount.ten) {
				coinCounter.Add10Coins ();
			} else if (type == Amount.thirty) {
				coinCounter.Add30Coins ();
			} else if (type == Amount.fifty) {
				coinCounter.Add50Coins ();
			}
			Destroy (this.gameObject);
		}
	}
}
