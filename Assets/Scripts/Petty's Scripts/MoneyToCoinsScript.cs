using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyToCoinsScript : MonoBehaviour {

	public int money = 100;
	public int coins = 0;

	public GameObject moneyText;
	public GameObject coinText;

	void Update(){
		moneyText.GetComponent<Text> ().text = "Money: " + money;
		coinText.GetComponent<Text> ().text = "Coins: " + coins;
	
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) {
			Time.timeScale = 0;
			gameObject.GetComponent<Canvas> ().enabled = true;
		}
	}
		public void Resume(){
			Time.timeScale = 1;
			gameObject.GetComponent<Canvas>().enabled = false;
		}

	public void Alchemy(){
		if (money >= 10) {
			money -= 10;
			coins += 1;
		}
	}
}