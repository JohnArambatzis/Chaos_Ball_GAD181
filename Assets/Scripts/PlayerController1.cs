using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float movement;

    public float barrierTimer;
    public GameObject barrier;
    public GameObject redBarrier;
    public Transform redBarrierSpawn;

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
        if (Input.GetKeyDown(KeyCode.D) && Time.timeScale > 0 && barrierTimer >= 10)
        {
            Instantiate(barrier, redBarrierSpawn.position, redBarrierSpawn.rotation);

            barrierTimer = 0;
        }
    }
}
