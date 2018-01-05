using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bosshealth : MonoBehaviour
{
    public int BossHealth = 500;

    void Update()
    {
        if (BossHealth <= 0)
        {
			Destroy (this.gameObject);
			SceneManager.LoadScene ("Level2");
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