using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrab : MonoBehaviour {

	public bool HasKey = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D myCollisionInfo) {

		if (myCollisionInfo.gameObject.tag == "Key") {

			Destroy (myCollisionInfo.gameObject);

			HasKey = true;
		}

		if (HasKey == true && myCollisionInfo.gameObject.name == "Dungeon Door") {

			myCollisionInfo.gameObject.GetComponent <Animator> ().enabled = true;
			myCollisionInfo.gameObject.GetComponent <BoxCollider2D> ().enabled = false;
		}
	}
}
