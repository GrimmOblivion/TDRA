using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TenBalls : MonoBehaviour {
	public int coins = 0;

	public GameObject coinText;


	void OnCollisionEnter2D(Collision2D MyCollisionInfo){
		Debug.Log (MyCollisionInfo.gameObject.name);
		if (MyCollisionInfo.gameObject.name == "Coin") {
			Destroy (MyCollisionInfo.gameObject);
			coins += 1; 
			if (coins >= 10) {
				SceneManager.LoadScene ("VictoryLevel");
			}
		}
	}
	void Update() {
		coinText.GetComponent<Text>().text = "Coins: "+ coins;
	

	}
}