using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public HeartSystem heart;
    public Moviment player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.kBCount = player.kBTime;
            if (collision.transform.position.x <= transform.position.x)
            {
                player.isKnockRight = true;
            }
            if (collision.transform.position.x > transform.position.x)
            {
                player.isKnockRight = false;
            }
            heart.health--;
            player.animator.SetTrigger("TakeDamage");
        }
    }
}
