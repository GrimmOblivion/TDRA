using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss2HealthLevel3 : MonoBehaviour {

	public int BossHealth = 300;

	void Update()
	{
		if (BossHealth <= 0)
		{
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D MyCollisionInfo)
	{
		if (MyCollisionInfo.gameObject.tag == "Bullet")
		{
			BossHealth -= 5;
		}
		if (MyCollisionInfo.gameObject.tag == "Hallway Sweeper")
		{
			BossHealth -= 50;
		}
	}
}