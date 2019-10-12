using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempBallScript : BallMovement
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(gameObject);
        }
    }
}
