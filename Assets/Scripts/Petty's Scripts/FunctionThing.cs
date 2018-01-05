using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionThing : MonoBehaviour {

	// Use this for initialization
	void Start () {

		//int sum = 
		IntReturn(12.7f , 13.6f);
		string BobName = NameLevel(11.2f , "Bob");
		intBob (15.5f , 515);
		Debug.Log (BobName);
	}
	float IntReturn (float num1, float num2){
		return num1 + num2;
	}
	string NameLevel(float level, string name){
		return name + level;	
	}
	void intBob(float num1, int num2){
		Debug.Log (num1 + num2);
	}
}