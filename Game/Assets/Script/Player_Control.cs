using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float speed;
    private Rigidbody2D player_body;
    private Animator anim;
    

    public float inputX, inputY;
    private float stopX, stopY;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = Camera.main.transform.position-transform.position;
        player_body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");
        inputY = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(inputX, inputY).normalized;
        player_body.velocity = input * speed;

        if (input != Vector2.zero)
        {
            anim.SetBool("isMoving", true);
            stopX = inputX;
            stopY = inputY;
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
        anim.SetFloat("InputX", stopX);
        anim.SetFloat("InputY", stopY);

        Camera.main.transform.position = transform.position + offset;
    }

    
}