using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

public class TankMovement : MonoBehaviour
{
    int Playerturn = 1;
    public float movespeed;
    public int playerNumber = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        {
          if (playerNumber == 1)
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 4.5f, 0, 0));
            }
          if (playerNumber == 2)
            {
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 4.5f, 0, 0));
            }

        }  
    }
}
