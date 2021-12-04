using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedMovement = 5f;
    public Rigidbody2D rb;
    public Animator animator;

   
        
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        Physics2D.IgnoreLayerCollision(7, 8);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speedMovement * Time.fixedDeltaTime);        
    }
}
