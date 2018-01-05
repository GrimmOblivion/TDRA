using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAppear : MonoBehaviour {

	public float AppearTimer = 0f;
	public float DisappearTimer = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		AppearTimer += Time.deltaTime;
		DisappearTimer += Time.deltaTime;

		if (AppearTimer >= 5) {

			gameObject.GetComponent <SpriteRenderer> ().enabled = true;
			gameObject.GetComponent <Animator> ().enabled = true;

		}

		if (DisappearTimer >= 5.5) {

			gameObject.GetComponent <SpriteRenderer> ().enabled = false;
			gameObject.GetComponent <Animator> ().enabled = false;

			AppearTimer = 0;
			DisappearTimer = 0;

		}
		
	}
}
