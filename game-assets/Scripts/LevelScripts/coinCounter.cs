using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinCounter : MonoBehaviour 
{
	public int coinCount;
	public Text coinText;

	void Start () 
	{
		PlayerPrefs.GetInt("Coins");
		coinCount = PlayerPrefs.GetInt("Coins");
		coinText.text = coinCount.ToString("00");
	}

	public void AddCoin() 
	{
		coinCount += 1;
		PlayerPrefs.SetInt("Coins", coinCount);
		coinText.text = coinCount.ToString ("00");
		PlayerPrefs.Save();
	}

	public void Add10Coins() 
	{
		coinCount += 10;
		PlayerPrefs.SetInt("Coins", coinCount);
		coinText.text = coinCount.ToString ("00");
		PlayerPrefs.Save();
	}

	public void Add30Coins() 
	{
		coinCount += 30;
		PlayerPrefs.SetInt("Coins", coinCount);
		coinText.text = coinCount.ToString ("00");
		PlayerPrefs.Save();
	}

	public void Add50Coins() 
	{
		coinCount += 50;
		PlayerPrefs.SetInt("Coins", coinCount);
		coinText.text = coinCount.ToString ("00");
		PlayerPrefs.Save();
	}
}
