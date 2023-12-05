using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Catnip_colect : MonoBehaviour
{
    // Start is called before the first frame update
    public LevelLoad load;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            load.real = true;
        }
    }
}
