using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float jumpStrength;

    private Rigidbody2D rb;
    private PlayerControls controls;

    private float movement;
    private bool isGrounded;

    public FriendController testFriend;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        controls = new PlayerControls();
        controls.Player.Movement.performed += ctx => movement = ctx.ReadValue<float>();
        controls.Player.Movement.canceled += _ => movement = 0;

        controls.Player.Jump.started += _ => Jump();

        controls.Player.StopFriend.started += _ => testFriend.Stop();

    }

    private void OnEnable() => controls.Enable();
    private void OnDisable() => controls.Disable();

    // Update is called once per frame
    void Update()
    {
        if (movement < 0 )
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (movement > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(movement * movementSpeed, rb.linearVelocity.y);
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpStrength);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
