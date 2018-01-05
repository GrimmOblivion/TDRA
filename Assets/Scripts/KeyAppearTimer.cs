using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAppearTimer : MonoBehaviour {

	public GameObject key;
	public float timer = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(timer);
		timer += Time.deltaTime;

		gameObject.GetComponent <SpriteRenderer> ().enabled = false;
		gameObject.GetComponent <BoxCollider2D> ().enabled = false;
		gameObject.GetComponent <Animator> ().enabled = false;

		if (timer >= 210) {

			gameObject.GetComponent <SpriteRenderer> ().enabled = true;
			gameObject.GetComponent <BoxCollider2D> ().enabled = true;
			gameObject.GetComponent <Animator> ().enabled = true;
		}
		
	}
}