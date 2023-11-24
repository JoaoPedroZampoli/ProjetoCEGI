using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int healthMax;

    public Image[] heart;
    public Sprite full;
    public Sprite voidd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthLogic();
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
}
