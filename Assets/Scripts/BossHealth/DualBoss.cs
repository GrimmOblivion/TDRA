using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DualBoss : MonoBehaviour {

	public GameObject Boss;
	public bool bossdead = false;

	public GameObject Boss2;
	public bool boss2dead = false;

    public int BossHealth = 900;
	public int Boss2Health = 500;

    void Update()
    {
		if (Boss == null && Boss2 == null) {
			//load next scene
			Debug.Log("foo");
			SceneManager.LoadScene("Between3andFinal");
		}

		if (bossdead == true && boss2dead == true) {

			SceneManager.LoadScene("Between3andFinal");
		}
        if (BossHealth <= 0)
        {
			bossdead = true;
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
