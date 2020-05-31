using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator playerAnimator;

    // Update is called once per frame
    void Update()
    {
        //Input
        movement.x = Input.GetAxisRaw("Horizontal"); //Values are: Left -1 || Right 1
        movement.y = Input.GetAxisRaw("Vertical"); // Down -1 || Up 1

        playerAnimator.SetFloat("Horizontal", movement.x);
        playerAnimator.SetFloat("Vertical", movement.y);
        playerAnimator.SetFloat("Speed", movement.sqrMagnitude); // Returns length of the vector
    }

    private void FixedUpdate() //called 50 times per second for smoother physics
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //Moves the rigid body at a set pace

    }
}
