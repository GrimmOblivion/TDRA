using UnityEngine;
using System.Collections;

public class RotationMove2 : MonoBehaviour {

	// Use this for initialization
	public float rotationSpeed = 5.0f;
	public float moveSpeed = 1.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("a")) {
			//rotate counter-clockwise
			transform.RotateAround(transform.position, new Vector3(0f,0f,1f), rotationSpeed);
		}

		if (Input.GetKey ("d")) {
			//rotate counter-clockwise
			transform.RotateAround(transform.position, new Vector3(0f,0f,1f), -rotationSpeed);
		}

		if (Input.GetKey ("w")) {
			//go forward. BUT HOW?!?!?!
			Debug.Log ("Right is " + transform.right);
			Debug.Log ("Forward is " + transform.forward);
			Debug.Log ("Up is " + transform.up);
			//just kidding, we need to go up instead
			GetComponent<Rigidbody2D> ().velocity = transform.up * moveSpeed;

		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0f, 0f);
		}
	}
}
