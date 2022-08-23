using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float movement;

    public float barrierTimer;
    public float ballBreakerTimer;

    public GameObject barrier;
    public GameObject blueBarrier;
    public GameObject redBallBreaker;

    public Transform blueSpawn;

    void Update()
    {

        movement = Input.GetAxisRaw("Vertical2");
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);


        if (barrierTimer < 10)
        {
            blueBarrier.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.2f);
            barrierTimer += Time.deltaTime;
        }
        if (barrierTimer >= 10)
        {
            blueBarrier.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.timeScale > 0 && barrierTimer >= 10)
        {
            Instantiate(barrier, blueSpawn.position, blueSpawn.rotation);

            barrierTimer = 0;
        }
    }
}
