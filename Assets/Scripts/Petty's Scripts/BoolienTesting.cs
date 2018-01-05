using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolienTesting : MonoBehaviour {
	public int money = 10;
	public int level = 1;
	// Use this for initialization
	void Start () {
		//need level 15 and $10k to build a house
		//&& means and
		//|| means or
		//! means not
		if (level >= 15 && money >= 10000 || true) {



			/*if (money >= 10000) {
			//build house
			}*/
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
