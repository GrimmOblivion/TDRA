using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnCollide : MonoBehaviour {
	public int coins = 0;
	public int Hp = 25;
	public int lives = 5;

	//set the coinText gameobject in the inspector
	//this will display the number of coins
	public GameObject coinText;
	public GameObject hptext;
	public GameObject livestext;
	public GameObject coinTimedText;
	//float timer = 3.0f;
	// Use this for initialization
	void Start () {
	}

	void Update(){
	
		//we want coin text to display the number of coins we have
		coinText.GetComponent<Text> ().text = "Coins: " + coins;
		hptext.GetComponent<Text> ().text = "Health: " + Hp;
		livestext.GetComponent<Text> ().text = "Lives: " + lives;
		/*
		timer += Time.deltaTime;
		if (timer <= 2) {
		}
		coinTimedText.GetComponents<Text>().text = "You got a coin!";
	}
	else{
		coinTimedText.GetComponents<Text>().text = "";

	}
	*/
	}
		void OnCollisionEnter2D(Collision2D myCollisionInfo){
		//if we collide with an object named coin	
		if (myCollisionInfo.gameObject.name == "Coin") {
			//destory coin
			Destroy(myCollisionInfo.gameObject);
			//add one to our coin count
			coins += 1; 
				//timer = 0;
			}
	
	}
}
