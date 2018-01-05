using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealthMK2 : MonoBehaviour
{
    public int PlayerHealth = 50;
    public GameObject PlayerHealthtext;

    void Update()
    { 
            PlayerHealthtext.GetComponent<Text>().text = "Health: " + PlayerHealth;

        if (PlayerHealth <= 0)
        {
            SceneManager.LoadScene("Level1Layout");
            gameObject.GetComponent<AudioSource> ().Play ();   
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Enemey")
        {
            PlayerHealth -= 2;
        }
        if (MyCollisionInfo.gameObject.tag == "Boss")
        {
            PlayerHealth -= 5;
        }
    }
}