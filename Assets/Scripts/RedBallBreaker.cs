using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBallBreaker : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private void Start()
    {
        Destroy(gameObject, 1);
    }

    void Update()
    {
        float x = -1;
        float y = 0;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "RedBall")
        {
            Destroy(collision.gameObject, 0.1f);
        }
    }
}
