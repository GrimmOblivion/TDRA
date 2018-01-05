using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//call the basic function
		BasicFunction ();
		ReceiveInt (17);
		//each call of AddInts function is independent
		AddInts (9, 18);
		AddInts (5, 12);
		AddInts (11, 157);
		//sum catches the return value from the call
		//of the function
		int sum = AddIntsReturnSum (3, 4);
		Debug.Log (sum);
		//it is okay to call the function and not catch
		//the value it returns
		//we may want to do this if the function does
		//multiple things
		AddIntsReturnSum (15, 37);
		string charStats = CharacterInfo (99, 320.5f, "Grimm");
		Debug.Log (charStats);
		
	
	}
	string CharacterInfo(int level, float damage, string name){
		return name + ": Level: " + level + ", Damage: " + damage;
	
	}

	//this function revceive two ints and returns back
	//to where is was called
	int AddIntsReturnSum (int num1, int num2){
		return num1 + num2;
	
	}

	//this funtion receive 2 ints and logs there sum to the console
	void AddInts(int num1, int num2){
		Debug.Log (num1 + num2);
	
	}

	//this function receive an int named number
	void ReceiveInt (int number){
		Debug.Log (number);
	
	}

	//used mostly for cleaning up code, so other function 
	//arent cluttered. perform a specific function
	void BasicFunction(){
		Debug.Log ("RarePepe");

	}
}