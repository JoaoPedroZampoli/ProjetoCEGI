using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public bool ground = true;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool facingRight = true;

    public Animator animator;
    //teste
    public float jumpForce = 5f;
    private bool isGrounded;

    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed* Time.deltaTime);
        ground = Physics2D.Linecast(groundCheck.position, transform.position, groundLayer);
        Debug.Log(ground);

        if(ground == false)
        {
            speed *= -1;
        }
        if(speed > 0 && !facingRight)
        {
            Flip();
        }else if(speed < 0 && facingRight){ 
            Flip();
        }

        isGrounded = Physics2D.OverlapCircle(transform.position, 0.2f, LayerMask.GetMask("Ground"));

        if (isGrounded )
        {
            Jump();
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scale = transform.localScale;
        Scale.x *= -1;
        transform.localScale = Scale;
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f); // Zera a velocidade vertical para evitar saltos consecutivos muito altos.
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
