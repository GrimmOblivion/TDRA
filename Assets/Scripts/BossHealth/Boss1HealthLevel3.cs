using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1HealthLevel3 : MonoBehaviour {

	public int BossHealth = 900;

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
			BossHealth -= 2;
		}
		if (MyCollisionInfo.gameObject.tag == "Hallway Sweeper")
		{
			BossHealth -= 50;
		}
	}
}