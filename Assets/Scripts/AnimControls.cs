using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControls : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		float in_x = Input.GetAxisRaw ("Horizontal");
		float in_y = Input.GetAxisRaw ("Vertical");

		bool IsWalking = (Mathf.Abs (in_x) + Mathf.Abs (in_y) > 0);
		if (IsWalking) {

			anim.SetFloat ("X", in_x);
			anim.SetFloat ("Y", in_y);

		}

		anim.SetBool ("IsWalking", IsWalking);
	}
}