using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public PlayerControls controls;
    public Rigidbody2D rb2d;
    public PlayerInputManager inputManager;

    Vector2 moveAxis;
    private float jumpValue;
    private float growValue;
    private float shrinkValue;
    public float speedModifier = 1;

    public float speed = 1f;

    public float jumpPower = 1f;
    private float jumpDuration;
    public float fallGravity = 25;
    [SerializeField]private bool grounded = true;

    private void Awake()
    {
        controls = new PlayerControls();

        rb2d = GetComponent<Rigidbody2D>();

        controls.Gameplay.Move.performed += ctx => moveAxis = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move.canceled += ctx => moveAxis = ctx.ReadValue<Vector2>();

        controls.Gameplay.Jump.started += ctx => Jump();
        controls.Gameplay.Jump.performed += ctx => PerformFall();
        controls.Gameplay.Jump.canceled += ctx => CancelFall();

        growValue = 0;
        controls.Gameplay.Grow.started += ctx => growValue = ctx.ReadValue<float>();
        controls.Gameplay.Grow.performed += ctx => growValue = 0f;
        controls.Gameplay.Grow.canceled += ctx => growValue = 0f;

        controls.Gameplay.Shrink.started += ctx => shrinkValue = ctx.ReadValue<float>();
        controls.Gameplay.Shrink.performed += ctx =>shrinkValue = 0;
        controls.Gameplay.Shrink.canceled += ctx => shrinkValue = 0;

        inputManager.onPlayerJoined += ctx => PlayerJoin();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(moveAxis);
        //Jump();
        Grow(growValue);
        Shrink(shrinkValue);
    }

    public void PlayerJoin()
    {
        
    }


    public void Jump()
    {
        if (grounded)
        {
            jumpDuration = 0;
            rb2d.gravityScale = 1;
            rb2d.AddForce(Vector2.up * jumpPower * 100, ForceMode2D.Impulse);
            grounded = false;
            Debug.Log("jump()");
        }       
    }

    public void PerformFall()
    {
        rb2d.gravityScale = fallGravity;
        Debug.Log("performfall()");
    }

    public void CancelFall()
    {
        rb2d.gravityScale = fallGravity;
        Debug.Log("cancelfall()");
    }

    public void Move(Vector2 direction)
    {      
        transform.position += (new Vector3(direction.x, 0, 0) * speed * Time.deltaTime);
    }

    public void Grow(float growVal)
    {
        if (growVal != 0 && transform.localScale.x < 2)
        {
            transform.localScale *= 1.02f;
            speed -= speedModifier * Time.deltaTime;
            Debug.Log("grow()");
        }       
    }

    public void Shrink(float shrinkVal)
    {
        if (shrinkVal != 0 && transform.localScale.x > 0.7)
        {
            transform.localScale *= 0.98f;
            speed += speedModifier * Time.deltaTime;
            Debug.Log("shrink()");
        }
    }

    private void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.Gameplay.Disable();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            grounded = true;
        }
    }
}
