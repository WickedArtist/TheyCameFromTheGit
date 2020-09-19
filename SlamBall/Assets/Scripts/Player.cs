using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float movespeed;
    public float jumpForce;
    public float fallMultiplier;
    public float lowJumpMultiplier;
    private GroundCheck groundCheck;


    // Start is called before the first frame update
    void Start()
    {
        groundCheck = GetComponentInChildren<GroundCheck>();

        rb2d = GetComponent<Rigidbody2D>();

        //movespeed = 30;
        //jumpForce = 200;
        //fallMultiplier = 20;
        //lowJumpMultiplier = 20;
    }

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetKeyDown("space") && groundCheck.isGrounded == true)
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("jump");
        }

        //Fall multipliers
        if (rb2d.velocity.y < 0)
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
        }
        else if (rb2d.velocity.y > 0 && !Input.GetKey("space"))
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        //Movement
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

