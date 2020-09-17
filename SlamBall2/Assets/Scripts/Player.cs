using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        movespeed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey("a"))
        {
            rb2d.AddForce(Vector2.left * Time.fixedDeltaTime * movespeed);
        }
        if (Input.GetKey("d"))
        {
            rb2d.AddForce(Vector2.right * Time.fixedDeltaTime * movespeed);
        }
    }
}
