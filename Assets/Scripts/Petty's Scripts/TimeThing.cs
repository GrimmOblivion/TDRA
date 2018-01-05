using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeThing : MonoBehaviour {
	float timer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;
		if (timer >= 5) {
		//spawn an enemy
			timer = 0;
		}
		//this is how you lose when you take to long
		//if you take more then 15 seconds you win 
		if(Time.timeSinceLevelLoad >= 15){
			//you lose the game
		}
	}
}
