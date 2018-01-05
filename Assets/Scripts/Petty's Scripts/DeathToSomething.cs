using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathToSomething : MonoBehaviour
{
    public GameObject bullet;
    public GameObject wizard;
    public int PlayerHealth = 10;
    public int WizardHealth = 50;
	public GameObject Attack2;

    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.name == "wizard")
        {
            WizardHealth -= 2;
        }
    }
    void KillTheTing()
    {
        if (WizardHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}

