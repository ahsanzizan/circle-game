using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 moveDir;

    [Header("Attributes")]
    public float moveSpeed;

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
        Vector2 playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 currentPos = (Vector2)this.transform.position;

        // Subtract player position and current position to get a direction
        moveDir = playerPos - currentPos;
        rb.MovePosition(rb.position + moveSpeed * Time.fixedDeltaTime * moveDir);
    }
}