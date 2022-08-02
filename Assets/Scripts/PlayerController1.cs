using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update()
    {

        movement = Input.GetAxisRaw("Vertical");


        rb.velocity = new Vector2(rb.velocity.x, movement * speed);

    }
}
