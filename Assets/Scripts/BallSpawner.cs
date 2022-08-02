using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float timer;

    public Transform redBallSpawn;
    public Transform blueBallSpawn;

    public GameObject redBall;
    public GameObject blueBall;


    void Update()
    {
        if (timer < 6)
        {
            timer += Time.deltaTime;
        }
        if (timer >= 6)
        {
            Instantiate(redBall, redBallSpawn.position, redBallSpawn.rotation);
            Instantiate(blueBall, blueBallSpawn.position, blueBallSpawn.rotation);

            timer = 0;
        }
    }
}
