using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankMovement : MonoBehaviour
{
    [SerializeField]
    private float Movespeed;
    public bool Tankcontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Tankcontroller == true)
        {
            transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * Movespeed * Time.deltaTime);
        }  
    }
}
