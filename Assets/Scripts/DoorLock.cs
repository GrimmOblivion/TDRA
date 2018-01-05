using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

	void Update () {

	}

	void OnTriggerExit2D (Collider2D collision) {

		if (collision.transform.gameObject.tag == "Player") {

		gameObject.GetComponent <PolygonCollider2D> ().enabled = true;

		}
	}
}