using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Reload : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {



        if (MyCollisionInfo.gameObject.name == "NextLevel")
        {
            SceneManager.LoadScene("Level2");
        }
        if (MyCollisionInfo.gameObject.name == "NextLevel1")
        {
            SceneManager.LoadScene("Between2andFinal");
        }
        if (MyCollisionInfo.gameObject.name == "NextLevel2")
        {
            SceneManager.LoadScene("LevelBoss");
        }
    }
}