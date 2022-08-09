using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float timer;
    public float ballSpawnTimer;

    public Transform redBallSpawn;
    public Transform blueBallSpawn;

    public GameObject redBall;
    public GameObject blueBall;

    public GameObject ballSpawner;


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


        if (ballSpawnTimer < 5)
        {
            ballSpawner.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 0.2f);
            ballSpawnTimer += Time.deltaTime;
        }
        if (ballSpawnTimer >= 5)
        {
            ballSpawner.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Time.timeScale > 0 && ballSpawnTimer >= 5)
        {
            ballSpawnTimer = 0;

            Instantiate(redBall, redBallSpawn.position, redBallSpawn.rotation);
            Instantiate(blueBall, blueBallSpawn.position, blueBallSpawn.rotation);
        }
    }
}
