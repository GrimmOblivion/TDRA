using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlaySound") {
            Camera.main.GetComponent<AudioSource>().Play();
        }
    }

}
