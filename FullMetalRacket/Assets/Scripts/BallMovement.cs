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
        else if (collidedObject.CompareTag("Wall"))
        {
            BounceOffWallMovement();
        }
        else if (collidedObject.CompareTag("BackWall"))
        {
            ReversalMovement();
        }

    }
    public void ReversalMovement()
    {
        float randomTurn = Random.Range(-.5f, .5f);

        direction.x = randomTurn;
        direction.y *= -1;
    }


    public void BounceOffWallMovement()
    {
        direction.x *= -1;

    }

}// end of class
