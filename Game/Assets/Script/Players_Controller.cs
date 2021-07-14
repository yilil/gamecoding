using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public float speed; //Player moving speed
    public float time;
    void Start()
    {
        return;
    }

    // Update is called once per frame
    void Update()
    {
       Movement(); 
    }

    void Movement() // Player's movement
    {
        // float.horizontalmove; // set up variable to save the input
        // horizontalmove = Input.GetAxis("Horizontal"); //Left(-1), Stable(0), Right(1) 

        // if(horizontalmove != 0)
        // {
        //     rb.volocity = new Vector2(horizontalmove * speed, rb.velocity.y);
        // }
    
    }
}
