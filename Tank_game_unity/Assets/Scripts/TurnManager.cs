using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private int Playerturn = 1;
    public GameObject Player1;
    public GameObject Player2;
    void Start()
    {
        GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in Players)
        {
            if (g.GetComponent<Player>().PlayerNumber == 1)
            {
                Player1 = g;
            }
            else if (g.GetComponent<Player>().PlayerNumber == 2)
            {
                Player2 = g;
            }
        }
        Invoke("Init", 0.1f);
    }
    private void Init()
    {
        //make player onturn active
        if (Playerturn == 1)
        {
            //make player 1 active
            Player1.GetComponent<Player>().SetActive(true);
            Player2.GetComponent<Player>().SetActive(false);
        }
        else if (Playerturn == 2)
        {
            //make player 2 active
            Player1.GetComponent<Player>().SetActive(false);
            Player2.GetComponent<Player>().SetActive(true);
        }
    }
    public void switchTurn()
    {
        if (Playerturn == 1)
        {
            if (Playerturn == 1)
            {
                //make player 1 active
                Player1.GetComponent<Player>().SetActive(true);
                Player2.GetComponent<Player>().SetActive(false);
            }
            else if (Playerturn == 2)
            {
                //make player 2 active
                Player1.GetComponent<Player>().SetActive(false);
                Player2.GetComponent<Player>().SetActive(true);
            }
        }
    }
}
