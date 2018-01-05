using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariables : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		//create an integer variable named myInteger and set its value to 3
		int myInteger = 3;
		Debug.Log (myInteger);
		//myInteger adds 1 to itself
		myInteger = myInteger + 1;
		myInteger += 1;
		myInteger++;
		Debug.Log (myInteger);

		//reduce myInteger by 2
		myInteger = myInteger - 2;
		myInteger -= 2;
		Debug.Log (myInteger);

		//create a decimal value  (called a float) named myFlaot and set its value to 7.3, end with an f
		float myFloat = 7.3f;
		Debug.Log (myFloat);

		//ceate a boolean variable named myBool and set its value to false
		bool myBool = false;
		Debug.Log (myBool);

		//create a string varaible  (words) named myString and set its value to Petty
		string myString = "Petty";
		Debug.Log (myString);

	}
	
	// Update is called once per frame
	void Update () {

	}
}
