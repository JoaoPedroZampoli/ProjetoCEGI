using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_script : MonoBehaviour
{
    public float Speed;
    public bool InFloor = true;
    public Transform groundCheck;
    public LayerMask GroundLayer;
    public bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        InFloor = Physics2D.Linecast(transform.position,groundCheck.position, GroundLayer) ;

        if (!InFloor)
        {
            Speed *= -1;
        }

        if(Speed > 0 && !facingRight) 
        {
             flip();
        }
        else if (Speed < 0 && facingRight)
        {
               flip();
        }
    }
    void flip()
    {
        facingRight = !facingRight;
       Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale= scale;
    }
}
