using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Variable for our speed modifier.
    public float moveSpeed;
    //Variable for Input
    public Vector2 movementInput;
    //Variable for RigidBody2D
    public Rigidbody2D rigidBody;
    //Variable for Animation
    public Animator anim;

    // Start is called before the first frame update.
    void Start()
    {
        //gets the rigid body from the player.
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame.
    void Update()
    {  
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            anim.enabled = true;
            anim.SetTrigger("ForwardAnimation");
        }

        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("BackwardAnimation");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            anim.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("LeftAnimation");
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.enabled = true;
            anim.SetTrigger("RightAnimation");
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.enabled = false;
        }
    }
    // Update that handles physics.
    private void FixedUpdate()
    {
        //Adds Velocity to the rigidbody.
        rigidBody.velocity = movementInput * moveSpeed;
    }
    
    // Converts Input to Vector.
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}
