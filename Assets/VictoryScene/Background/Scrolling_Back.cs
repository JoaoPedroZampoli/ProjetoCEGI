using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling_Back : MonoBehaviour
{
    // Start is called before the first frame update
    public MeshRenderer mr;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
