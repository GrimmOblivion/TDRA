using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefVar : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetFloat("CritChance", 0.1f);
        PlayerPrefs.SetInt("Health", 50);
        PlayerPrefs.SetString("Name", "Mario");

      

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
