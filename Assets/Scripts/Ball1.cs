using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    
    void Start()
    {
        Launch1();
    }

    
    void Update()
    {
        
    }

    private void Launch1()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);

    }
}
