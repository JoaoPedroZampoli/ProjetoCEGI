using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    //Velocidade 
    private float horizontal;
<<<<<<< HEAD
    private float speed = 8f;

    //Pulo
    private float jumpingPower = 16f;
=======
    public float speed = 8f;
    public float jumpingPower = 10f;
>>>>>>> 89a46d6117316f9ff1f3b8baaabb96f50ed4f11d
    private bool isFacingRight = true;
    public bool InFloor;
    public Transform DetectsGround;
    public LayerMask Floor;

    //Moviemntação do player
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    //Animator
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();

    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetBool("Jump", true);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();


        InFloor = Physics2D.OverlapCircle(DetectsGround.position, 0.2f, Floor);

        //Animator

        //Run
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        //jump
        if (InFloor &&  rb.velocity.y == 0)
        {
            animator.SetBool("Jump", false);
        }
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Jump", true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
