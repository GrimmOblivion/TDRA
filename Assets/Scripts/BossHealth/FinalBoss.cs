using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FinalBoss : MonoBehaviour {

    public int BossHealth = 2000;


    void Update()
    {
        if (BossHealth <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Credits");
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
