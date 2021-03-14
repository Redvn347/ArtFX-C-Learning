using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
  

    // Start is called before the first frame update
    void Start()
    {
        Launch();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(1, 2); // move a randomize number 
        float y = Random.Range(1, 2);
        rb.velocity = new Vector2(speed * x, speed * y);
    }


}

