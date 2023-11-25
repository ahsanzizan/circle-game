using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 movement;

    [Header("Attributes")]
    public float moveSpeed = 10f;

    void Start()
    {
        if (rb == null)
        {
            rb = this.GetComponent<Rigidbody2D>();
        }
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal"), moveY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(moveX, moveY).normalized;
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }
}
