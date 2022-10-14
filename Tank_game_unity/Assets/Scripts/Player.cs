using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int PlayerNumber;
    [SerializeField]
    Material inactiveMat;
    [SerializeField]
    Material activeMat;
    bool OnTurn = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().material = inactiveMat;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnTurn == true)
        {
            Invoke("switchTurn", 0.1f);
        }
    }
    void switchTurn()
    {
        GameObject.Find("GameManager").GetComponent<TurnManager>().switchTurn();
    }
    public void SetActive(bool b)
    {
        // ?????
        // ?????
        if (b == true)
        {
            OnTurn = true;
            GetComponent<SpriteRenderer>().material = activeMat;
        }
        else
        {
            OnTurn = false;
            GetComponent<SpriteRenderer>().material = inactiveMat;
        }
    }
    public void setTurn (bool b)
    {
        if (b == true)
        {
            GetComponent<MeshRenderer>().material = activeMat;
            Invoke("SetTrue", 0.2f);
        }
        else
        {
            OnTurn = false;
            GetComponent<MeshRenderer>().material = inactiveMat;
        }
    }
    void SetTrue()
    {
        OnTurn = true;
    }
    private void update()
    {
        if (OnTurn == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log(PlayerNumber);

                GameObject.Find("GameEngine").GetComponent<TurnEngine>().switchTurn();
            }
        }
    }
}
