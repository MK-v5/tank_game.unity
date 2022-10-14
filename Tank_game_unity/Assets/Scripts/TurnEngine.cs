using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEngine : MonoBehaviour
{
    int playerTurn = 1;
    public GameObject Player1;
    public GameObject Player2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in Players)
        {
            if (g.GetComponent<Player>().PlayerNumber == 1)
            {
                Player1 = g;
            }
            if (g.GetComponent<Player>().PlayerNumber == 2)
            {
                Player2 = g;
            }
        }
        Player1.GetComponent<Player>().setTurn(true);
        Player2.GetComponent<Player>().setTurn(false);
    }
    public void switchTurn()
    {
        if (playerTurn == 1)
        {
            playerTurn = 2;
            Player1.GetComponent<Player>().setTurn(false);
            Player2.GetComponent<Player>().setTurn(true);
        }
        if (playerTurn == 2)
        {
            playerTurn = 1;
            Player1.GetComponent<Player>().setTurn(true);
            Player2.GetComponent<Player>().setTurn(false);
        }
    }
}
