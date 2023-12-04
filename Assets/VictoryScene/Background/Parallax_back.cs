using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax_back : MonoBehaviour
{
    // Start is called before the first frame update
    private float length;
    private float Startpos;
    private Transform cam;
    public float ParallaxEffect;
    void Start()
    {
        Startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float repos = cam.transform.position.x * (1 - ParallaxEffect);
        float Distance = cam.transform.position.x * ParallaxEffect;
        transform.position = new Vector3(Startpos * Distance, transform.position.y, transform.position.z);
    }
}
