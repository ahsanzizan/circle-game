using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 movement;

    [Header("Attributes")]
    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        if (rb == null)
        {
            rb = this.GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal"), moveY = Input.GetAxisRaw("Vertical");
        movement = new Vector2(moveX, moveY);
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * movement);
    }
}
