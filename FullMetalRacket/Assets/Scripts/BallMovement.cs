using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : AutoMove
{
    float stuckTimer;
    public float gameTimer = 0;

    public void Update()
    {
        gameTimer += Time.deltaTime;

        if ((gameTimer >= 30f) && (this.speed < 25f))
        {
            this.speed += 5f;
            gameTimer = 0;
        }

    }

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
        float randomTurn = Random.Range(-.75f, .75f);

        direction.x = randomTurn;
        direction.y *= -1;

        GetComponent<Rigidbody2D>().AddForce(direction*speed, ForceMode2D.Impulse);

    }


    public void BounceOffWallMovement()
    {
        direction.x *= -1;

        direction.x += .5f;
        //this adds a better bounce off the wall
        GetComponent<Rigidbody2D>().AddForce(direction * speed, ForceMode2D.Impulse);
    }

}// end of class
