using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float movespeed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        movespeed = 5000;
        jumpForce = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb2d.AddForce((Vector2.left * movespeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey("d"))
        {
            rb2d.AddForce((Vector2.right * movespeed * Time.fixedDeltaTime));     
        }
        if (Input.GetKeyDown("space"))
        {
            rb2d.AddForce(Vector2.up * jumpForce);
            Debug.Log("jump");
        }
    }
}

