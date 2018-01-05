using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCommand : MonoBehaviour {

	public float number = 10.0f;

	// Use this for initialization
	void Start () {


		Debug.Log ("Kill the PLAYER!!!!");
		Debug.Log ("Im confused, Whats going on?");
		Debug.Log ("Health: " + number);
		if (number >= 0) {
			number -= 10;	}
		Debug.Log ("You were stabbed -10 Health");
		if (number <= 0){
			Debug.Log ("You have died");
			return;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	

	}
}