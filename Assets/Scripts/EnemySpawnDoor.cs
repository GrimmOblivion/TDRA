using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnDoor : MonoBehaviour {

	public GameObject Wizard;
	public float SpawnDelay = 2.0f;
	float timer = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer >= SpawnDelay) {

			GameObject wizard = (GameObject)Instantiate(Wizard, transform.position, Quaternion.identity);
			wizard.GetComponent<AIPath> ().target = GameObject.FindGameObjectWithTag ("Player").transform;
			timer = 0;

		}
		
	}

	void OnCollisionEnter2D (Collision2D myCollisionInfo) {
		
		myCollisionInfo.gameObject.GetComponent <BoxCollider2D> ().enabled = true;
		myCollisionInfo.gameObject.GetComponent <Animator> ().enabled = false;

		if (myCollisionInfo.gameObject.name == "EnemySpawnDoor") {

			myCollisionInfo.gameObject.GetComponent <Animator> ().enabled = true;
			myCollisionInfo.gameObject.GetComponent <BoxCollider2D> ().enabled = false;

		}
	}
}