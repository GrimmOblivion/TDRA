using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DualBoss2 : MonoBehaviour {

	public GameObject Boss2;

    public int BossHealth2 = 500;


    void Update()
    {
        if (BossHealth2 <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            BossHealth2 -= 5;
        }
        if (MyCollisionInfo.gameObject.tag == "Hallway Sweeper")
        {
            BossHealth2 -= 50;
        }
    }


}
