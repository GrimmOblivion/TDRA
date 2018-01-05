using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFinalBoss : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D myCollisionInfo)
    {
        if (myCollisionInfo.gameObject.name == "Next")
        {
            SceneManager.LoadScene("FinalBossFight");
        }
    }
}