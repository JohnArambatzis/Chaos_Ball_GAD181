using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update()
    {

        movement = Input.GetAxisRaw("Vertical2");


        rb.velocity = new Vector2(rb.velocity.x, movement * speed);

    }
}
