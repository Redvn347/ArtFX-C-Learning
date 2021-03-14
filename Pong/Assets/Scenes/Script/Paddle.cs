using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical"); // get the input axis we duplicated from the input manager, without smoothing
            Debug.Log("P1 moving");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical 2");
            Debug.Log("P2 moving");
        }
        rb.velocity = new Vector2(0, movement * speed /* Time.deltaTime*/); // vector 2 moves with the x of rigidbody, which is locked, and the y of Movement*speed*deltatime
        Debug.Log("ez gud");    // doesn't work with delta time?
    }

}
