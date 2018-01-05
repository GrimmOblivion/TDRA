using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

	public int Hp = 10;
	public bool myBool = true;
	public string Name;
	public float xp = 0f;
	// Use this for initialization
	void Start () {

		//if certain conditoins are met, then we will do something
		//if conditoins are not met, then we will not do something
		bool myTrueFalse = true;

		if (myTrueFalse) {
			Debug.Log ("Murp?");
		}
		xp += 2;
			
		if (xp >= 2) {
			Debug.Log ("Level up! level 2!");
		}

		//this compare the nu,ber 5 to 3 and gives a boolen
		//based on the answer (is 5 greater then or = to 3?)
		//>= means greater or equal to, <= means less then or =
		//> means only greater, < means only less then
		//== only equals to, != means not equal
		if (Hp >= 3) {
			Debug.Log ("We're still mostly alive!");
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}