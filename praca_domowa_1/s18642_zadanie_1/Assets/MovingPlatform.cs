using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
   
    public float speed = 400;
    public float directionX = 3;
    private bool move;

    void Update()
    {
      if (transform.position.x > 4)
        {
            move = false;
        } else if (transform.position.x < -4)
        {
            move = true;
        }

        if (move)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        } else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }

    }

}
