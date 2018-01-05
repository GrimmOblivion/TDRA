using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit2D (Collider2D collision) {

		if (collision.transform.gameObject.tag == "Player") {

			gameObject.GetComponent <EnemySpawnDoor> ().enabled = true;

		}
	}
}
