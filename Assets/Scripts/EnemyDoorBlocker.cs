using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoorBlocker : MonoBehaviour {

	public GameObject EnemyDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D myCollisionInfo) {

		myCollisionInfo.gameObject.GetComponent <BoxCollider2D> ().enabled = false;

		if (myCollisionInfo.gameObject.name == "DoorBlocker") {

			myCollisionInfo.gameObject.GetComponent <BoxCollider2D> ().enabled = true;
		}
	}
}