using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaLogic : MonoBehaviour
{
    Moviment player;
    public bool IsDead;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsDead = true;
            player.animator.SetBool("IsDead", IsDead);
            GetComponent<Moviment>().enabled = false;
            Destroy(gameObject, 1.0f);
        }
    }
}
