using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed;
    public Rigidbody2D rb;

    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask ground;
        
    private float jumpTimeCounter;
    public float jumpTime;
    public bool isjumping;

    public float jumpForce;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(walkSpeed * direction * Time.deltaTime, rb.velocity.y);
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, ground);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            isjumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKey(KeyCode.Space) && isjumping)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isjumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isjumping = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            collision.gameObject.GetComponent<Exit>().NextLevel();
        }
    }
}
