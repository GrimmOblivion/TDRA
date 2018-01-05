using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hallway2BossTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D myCollisionInfo)
	{

		if (myCollisionInfo.gameObject.tag == "BossRoomEnter") {

			SceneManager.LoadScene ("FinalBossFight");
		}
	}
}