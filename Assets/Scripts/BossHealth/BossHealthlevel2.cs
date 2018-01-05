using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealthlevel2 : MonoBehaviour {

	public int BossHealth = 900;

	void Update()
	{
		if (BossHealth <= 0)
		{
			Destroy (this.gameObject);
			SceneManager.LoadScene ("Level3");
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