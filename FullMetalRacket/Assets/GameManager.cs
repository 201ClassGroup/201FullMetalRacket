using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public List<GameObject> playerOneBlocks;
    public bool player1Lost = false;
    public List<GameObject> playerTwoBlocks;
    public bool player2Lost = false;

    public void Update()
    {
        for (int i = 0; i < playerOneBlocks.Count; i++)
        {
            if (playerOneBlocks[i] == null)
            {
                playerOneBlocks.Remove(playerOneBlocks[i]);
            }
        }

        for (int i = 0; i < playerTwoBlocks.Count; i++)
        {
            
            if (playerTwoBlocks[i] == null)
            {
                playerTwoBlocks.Remove(playerTwoBlocks[i]);
            }
        }

        if (playerOneBlocks.Count <= 0)
        {//if the player list of blocks is 0 then player one loses
            player1Lost = true;

        }
        else if (playerTwoBlocks.Count <= 0 )
        {//if the player 2 list is 0 then player 2 loses
            player2Lost = true;

        }

    }

}
