using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosslevel3Spawner : MonoBehaviour {

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
            if(wizard.GetComponent<AIPath>() != null)
			    wizard.GetComponent<AIPath> ().target = GameObject.FindGameObjectWithTag ("Player").transform;
			timer = 0;

		}

	}

}