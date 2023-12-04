using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catnip_colect : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
            collision.gameObject.GetComponent<Moviment>().enabled = false;
            collision.gameObject.GetComponent<Animator>().SetBool("Jump", false);
            LoadScene();
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene("VictoryScene");
    }
}
