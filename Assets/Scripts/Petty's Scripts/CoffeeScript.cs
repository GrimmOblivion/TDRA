using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeScript : MonoBehaviour {
	/*this script is going to receive user input
	 * when the user presses space, depending on
	 * the time space is held
	 * will determine the temp of the coffee
	 * */

	float coffeeTemp = 170.0f;
	float hotLimit = 140.0f;
	float coldLimit = 98.0f;

	// Update is called once per frame
	void Update () {
	
		coffeeTemp -= Time.deltaTime * 5;
		if (Input.GetKeyDown (KeyCode.Space)) {
			DrinkMyCoffee ();
		}
	}
	void DrinkMyCoffee(){
	//Coffee is to hot
		if (coffeeTemp >= hotLimit) { 
			Debug.Log ("You burned your tounge, you will never taste again.");
		}
	//Coffee is just right
		else if (coffeeTemp < hotLimit && coffeeTemp > coldLimit) {
			Debug.Log ("Your coffee is perfect, life i great!");
		}
	//Coffee is to cold
	//if coffeeTemp is less then or equal to the cold limit
		else{
		Debug.Log ("Your coffee is to cold, you waited to long, your morning is ruined");	
		}
	}
}
