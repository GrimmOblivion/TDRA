using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoonBossShoot : MonoBehaviour {

	public float timer = 0f;
	public GameObject GoonBossAttack;
	public float shootDistance = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		Vector3 spawnPosition = transform.position;
		Vector3 playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Vector3 shootDir = playerPos - spawnPosition;


		if (timer >= 2 && shootDir.magnitude < shootDistance) {

			GameObject GoonBoss = (GameObject)Instantiate (GoonBossAttack, spawnPosition, Quaternion.identity);
		//	GoonBoss.GetComponent<EnemyMove> ().player = GameObject.FindGameObjectWithTag ("Player").transform;

			timer = 0;

		}
		
	}
}