using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float timer = 0.0f;
	public float spawntimer = 2.0f;
	public GameObject prefab;

	// Use this for initialization
	void Start () {
		timer = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 spawnPosition = transform.position;
		
		if (timer == spawntimer) {

			GameObject enemy = (GameObject)Instantiate (prefab, spawnPosition, Quaternion.identity);
		}
	}
}
