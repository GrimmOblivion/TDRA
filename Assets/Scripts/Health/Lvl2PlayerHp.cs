using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Lvl2PlayerHp : MonoBehaviour	{
    public int PlayerHealth = 50;
    public GameObject PlayerHealthtext;

    void Update()
    {
        PlayerHealthtext.GetComponent<Text>().text = "Health: " + PlayerHealth;

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

		if (PlayerHealth <= 0 && MyCollisionInfo.gameObject.tag == "Boss") {

			gameObject.GetComponent<AudioSource> ().Play ();

			SceneManager.LoadScene("StartScreen");

			}

		if (PlayerHealth <= 0 && MyCollisionInfo.gameObject.tag == "Enemey") {

			gameObject.GetComponent<AudioSource> ().Play ();

			SceneManager.LoadScene ("StartScreen");

		}
	}
}