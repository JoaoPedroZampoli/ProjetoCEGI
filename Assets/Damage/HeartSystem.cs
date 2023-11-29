using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HeartSystem : MonoBehaviour
{
    // Start is called before the first frame update
    Moviment player;
    public bool IsDead;
    public int health;
    public int healthMax;

    public Image[] heart;
    public Sprite full;
    public Sprite voidd;
    void Start()
    {
        player = GetComponent<Moviment>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
        DeadState();


    }
    void HealthLogic()
    {
        for (int i = 0; i < heart.Length; i++)
        {
            if (health > healthMax)
            {
                health = healthMax;
            }

            if(i < health)
            {
                heart[i].sprite = full;
            }
            else
            {
                heart[i].sprite = voidd;
            }

            if (i < healthMax)
            {
                heart[i].enabled = true;
            }else
            {
                heart[i].enabled = false;
            }
        }
    }
    void DeadState()
    {
        if (health <= 0 && !IsDead)
        {
            IsDead = true;
            player.animator.SetBool("IsDead", IsDead);
            GetComponent<Moviment>().enabled = false;
            StartCoroutine(LoadSceneAfterDeath());
        }
    }


    IEnumerator LoadSceneAfterDeath()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
