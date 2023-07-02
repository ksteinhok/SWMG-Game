using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    public float moveSpeed = 5f;

    public Rigidbody2D wiz;
    public Vector2 smoothedMoveInput;
    public Vector2 movementInputSmoothVelocity;

    Vector2 movement;   //vec2 gets both axis
    // Update is called once per frame
    void Update()
    {   // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    { //movement for better physics
        smoothedMoveInput = Vector2.SmoothDamp(
            smoothedMoveInput,
            movement,
            ref movementInputSmoothVelocity,
            0.12f
            );
        wiz.MovePosition(wiz.position + smoothedMoveInput * moveSpeed *Time.fixedDeltaTime);
        
    }
}
