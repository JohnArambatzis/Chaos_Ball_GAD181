using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float movement;

    public float barrierTimer;
    public float ballBreakerTimer;

    public GameObject barrier;
    public GameObject redBarrier;

    public GameObject blueBallBreakerPower;
    public GameObject blueBallBreaker;

    public Transform redSpawn;

    void Update()
    {
        movement = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);


        if (barrierTimer < 10)
        {
            redBarrier.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.2f);
            barrierTimer += Time.deltaTime;
        }
        if (barrierTimer >= 10)
        {
            redBarrier.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.A) && Time.timeScale > 0 && barrierTimer >= 10)
        {
            Instantiate(barrier, redSpawn.position, redSpawn.rotation);

            barrierTimer = 0;
        }





        if (ballBreakerTimer < 5)
        {
            blueBallBreakerPower.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.2f);
            ballBreakerTimer += Time.deltaTime;
        }
        if (ballBreakerTimer >= 5)
        {
            blueBallBreakerPower.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.D) && Time.timeScale > 0 && ballBreakerTimer >= 5)
        {
            Instantiate(blueBallBreaker, redSpawn.position, redSpawn.rotation);

            ballBreakerTimer = 0;
        }
    }
}
