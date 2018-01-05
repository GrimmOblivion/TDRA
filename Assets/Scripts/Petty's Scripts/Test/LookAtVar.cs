using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtVar : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Debug.Log(PlayerPrefs.GetFloat("CritChance"));
        Debug.Log(PlayerPrefs.GetInt("Health"));
        Debug.Log(PlayerPrefs.GetString("Name"));

        PlayerPrefs.SetFloat("CritChance", PlayerPrefs.GetFloat("CritChance") + 0.1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
