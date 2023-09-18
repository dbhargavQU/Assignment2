using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysBounce : MonoBehaviour
{
    // how far you bounce
    public float jumpVelocity = 5f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when you collide with anything, give it a velocity up
        rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
    }
}
