using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : AutoMove
{
    float stuckTimer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (collidedObject.CompareTag("Player") || collidedObject.CompareTag("BackWall") )
        {
            ReversalMovement();
        }
        else if (collidedObject.CompareTag("Wall"))
        {
            BounceOffWallMovement();
        }
        else if ( collidedObject.CompareTag("Block"))
        {
            ReversalMovement();
            collidedObject.GetComponent<BlockScript>().AddHit();
        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        stuckTimer += Time.deltaTime;

        if (collision.gameObject.CompareTag("Block") || collision.gameObject.CompareTag("BackWall"))
        {
            if (stuckTimer >= .05)
            {
                ReversalMovement();
            }
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        stuckTimer = 0;
    }

    public void ReversalMovement()
    {
        float randomTurn = Random.Range(-.5f, .5f);

        direction.x = randomTurn;
        direction.y *= -1;

        GetComponent<Rigidbody2D>().AddForce(direction*speed, ForceMode2D.Impulse);

    }


    public void BounceOffWallMovement()
    {
        direction.x *= -1;

    }

}// end of class
