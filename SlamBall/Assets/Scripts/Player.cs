using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float movespeed;
    public float jumpForce;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 1.5f;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        movespeed = 30;
        jumpForce = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb2d.AddForce(Vector2.up * jumpForce);
            Debug.Log("jump");
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb2d.transform.Translate((Vector2.left * movespeed * Time.fixedDeltaTime));
        }
        if (Input.GetKey("d"))
        {
            rb2d.transform.Translate((Vector2.right * movespeed * Time.fixedDeltaTime));     
        }
    }
}

