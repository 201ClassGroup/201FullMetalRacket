using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : AutoMove
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.CompareTag("Player"))
        {
            ReversalMovement();
        }

    }
    public void ReversalMovement()
    {
        direction.y *= -1;
    }
}
