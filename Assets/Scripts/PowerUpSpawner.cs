using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public float timerSpeedUp;
    public float timerSpeedDown;

    public GameObject speedUp;
    public GameObject speedDown;

    private void Start()
    {
        timerSpeedUp = 4;
    }
    void Update()
    {
        if (timerSpeedUp < 7)
        {
            timerSpeedUp += Time.deltaTime;
        }
        if (timerSpeedUp >= 7)
        {
            timerSpeedUp = 0;

            float spawnY = Random.Range(-3.5f, 3.5f);
            float spawnX = Random.Range(-1.5f, 1.5f);

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(speedUp, spawnPosition, Quaternion.identity);
        }


        if (timerSpeedDown < 8)
        {
            timerSpeedDown += Time.deltaTime;
        }
        if (timerSpeedDown >= 8)
        {
            timerSpeedDown = 0;

            float spawnY = Random.Range(-3.5f, 3.5f);
            float spawnX = Random.Range(-3.5f, 3.5f);

            Vector2 spawnPosition = new Vector2(spawnX, spawnY);
            Instantiate(speedDown, spawnPosition, Quaternion.identity);
        }
    }
}
