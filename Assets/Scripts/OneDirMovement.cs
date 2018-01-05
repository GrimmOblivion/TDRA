using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class OneDirMovement : MonoBehaviour
{

    // Use this for initialization
    bool vert = false;
    bool horiz = false;
    public float movementSpeed = 5.5f;
	public float sprintSpeed;
	public float timer = 0.0f;
    Vector2 move;
    void Start()
    {
        move = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {

		timer = Time.deltaTime;

		sprintSpeed = movementSpeed * 2;
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal == 0 && vertical == 0)
        {
            move = Vector2.zero;
        }
        if (vertical == 0)
        {
            vert = false;
            move.y = 0;
        }
        if (horizontal == 0)
        {
            horiz = false;
            move.x = 0;
        }

        if (horiz == false && horizontal != 0)
        {
            horiz = true;
            move = new Vector2(horizontal, 0);

        }
        if (vert == false && vertical != 0)
        {
            vert = true;
            move = new Vector2(0, vertical);

        }
        if (horiz && !vert && vertical != 0)
        {
            vert = true;
            move = new Vector2(0, vertical);
        }
        if (vert && !horiz && horizontal != 0)
        {
            horiz = true;
            move = new Vector2(horizontal, 0);
        }

        if (vert && !horiz && vertical != 0)
        {
            move = new Vector2(0, vertical);

        }
        if (horiz && !vert && horizontal != 0)
        {
            move = new Vector2(horizontal, 0);

        }

		if (Input.GetKey (KeyCode.LeftShift)) {

			gameObject.GetComponent<Rigidbody2D> ().velocity = move * sprintSpeed;

		} else {

			gameObject.GetComponent<Rigidbody2D> ().velocity = move * movementSpeed;

			if (timer >= 5) {


			}

		}

    }
}
