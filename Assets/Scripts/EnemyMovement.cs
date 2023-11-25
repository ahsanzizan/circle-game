using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 moveDir;

    [Header("Attributes")]
    public float moveSpeed;

    void Start()
    {
        if (rb == null)
        {
            rb = this.GetComponent<Rigidbody2D>();
        }
    }

    void FixedUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        
        if (player != null)
        {
            Vector2 playerPos = player.transform.position;
            Vector2 currentPos = (Vector2)this.transform.position;

            // Subtract player position and current position to get a direction
            moveDir = (playerPos - currentPos).normalized;
            rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * moveDir);
        }
    }
}
