using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBlue : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    
    void Start()
    {
        Launch2();
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "SpeedUp")
        {
            Destroy(collision.gameObject, 0.1f);
            speed += 2;

            float x = Random.Range(0, 2) == 0 ? -1 : 1;
            float y = Random.Range(0, 2) == 0 ? -1 : 1;
            rb.velocity = new Vector2(speed * x, speed * y);
        }


        if (collision.transform.tag == "SpeedDown")
        {
            Destroy(collision.gameObject, 0.1f);
            if (speed > 2)
            {
                speed -= 2;
            }

            float x = Random.Range(0, 2) == 0 ? -1 : 1;
            float y = Random.Range(0, 2) == 0 ? -1 : 1;
            rb.velocity = new Vector2(speed * x, speed * y);
        }
    }

    private void Launch2()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
