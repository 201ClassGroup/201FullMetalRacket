using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    GameManager gm;

    public Text endingText;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.player1Lost)
        {//if the player 1 lost then the message will say player 2 won
            endingText.text = "Player 2 Wins!";
        }
        else if (gm.player2Lost)
        {//message will show player 1 won

            endingText.text = "Player 1 Wins!";
        }
    }
}
