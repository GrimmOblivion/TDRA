using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBig : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float scale = gameObject.GetComponent<CircleCollider2D>().radius;
        scale += Time.deltaTime * 0.2f;
        gameObject.GetComponent<CircleCollider2D>().radius = scale;
	}
}
