using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class TestMovTurn : MonoBehaviour {
    bool vert = false;
    bool horiz = false;
    public float movementSpeed = 5.5f;
    Vector2 move;

    public float rotationSpeed = 5.0f;
    public float moveSpeed = 1.0f;
    void Start()
    {
        move = Vector2.zero;
    }
    // Update is called once per frame
    void Update()
    {
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
            if (Input.GetKey("a"))
            {
                //rotate counter-clockwise
                transform.RotateAround(transform.position, new Vector3(0f, 0f, 1f), rotationSpeed);
            }

            if (Input.GetKey("d"))
            {
                //rotate counter-clockwise
                transform.RotateAround(transform.position, new Vector3(0f, 0f, 1f), -rotationSpeed);
            }

            if (Input.GetKey("w"))
            {
                //go forward. BUT HOW?!?!?!
                Debug.Log("Right is " + transform.right);
                Debug.Log("Forward is " + transform.forward);
                Debug.Log("Up is " + transform.up);
                //just kidding, we need to go up instead
                GetComponent<Rigidbody2D>().velocity = transform.up * moveSpeed;

            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            }
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = move * movementSpeed;
    }
}
