using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 400;

    int direction = 1;

    private bool hitWall;

   void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        float xDisplacement = direction * speed * Time.deltaTime;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.x);

        if (hitWall == true)
        {
            direction *= -1;
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        hitWall = true;
    }
}
