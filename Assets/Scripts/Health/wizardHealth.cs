using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizardHealth : MonoBehaviour
{
    public int WizardHealth = 10;

    void Update()
    {
        if (WizardHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D MyCollisionInfo)
    {
        if (MyCollisionInfo.gameObject.tag == "Bullet")
        {
            WizardHealth -= 5;
        }
        if (MyCollisionInfo.gameObject.tag == "Hallway Sweeper")
        {
            WizardHealth -= 50;
        }
    }
}