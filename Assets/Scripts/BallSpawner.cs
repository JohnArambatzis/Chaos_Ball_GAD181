using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSpawner : MonoBehaviour
{
    public float timer;
    public float goldBallTimer;
    public float ballSpawnTimer;

    public Transform redBallSpawn;
    public Transform blueBallSpawn;
    public Transform universalSpawn;

    public GameObject redBall;
    public GameObject blueBall;
    public GameObject goldBall;
    public GameObject ballSpawner;

    public GameObject ballSpawnTimerTwoSecondsButton;
    public GameObject ballSpawnTimerFourSecondsButton;
    public GameObject ballSpawnTimerNormalTimeButton;
    public bool twoSeconds = false;
    public bool fourSeconds = false;
    public bool normalTimer = true;

    public GameObject goldBallSpawnTimerOneSecondButton;
    public GameObject goldBallSpawnTimerFiveSecondsButton;
    public GameObject goldBallSpawnTimerNormalTimeButton;
    public bool goldOneSecond = false;
    public bool goldFiveSeconds = false;
    public bool goldNormalTimer = true;


    void Update()
    {
        if (twoSeconds == true)
        {
            if (timer < 2)
            {
                timer += Time.deltaTime;
            }
            if (timer >= 2)
            {
                Instantiate(redBall, redBallSpawn.position, redBallSpawn.rotation);
                Instantiate(blueBall, blueBallSpawn.position, blueBallSpawn.rotation);

                timer = 0;
            }
        }
        if (fourSeconds == true)
        {
            if (timer < 4)
            {
                timer += Time.deltaTime;
            }
            if (timer >= 4)
            {
                Instantiate(redBall, redBallSpawn.position, redBallSpawn.rotation);
                Instantiate(blueBall, blueBallSpawn.position, blueBallSpawn.rotation);

                timer = 0;
            }
        }
        if (normalTimer == true)
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







        if(goldOneSecond == true)
        {
            if (goldBallTimer < 1)
            {
                goldBallTimer += Time.deltaTime;
            }
            if (goldBallTimer >= 1)
            {
                Instantiate(goldBall, universalSpawn.position, universalSpawn.rotation);

                goldBallTimer = 0;
            }
        }
        if(goldFiveSeconds == true)
        {
            if (goldBallTimer < 10)
            {
                goldBallTimer += Time.deltaTime;
            }
            if (goldBallTimer >= 10)
            {
                Instantiate(goldBall, universalSpawn.position, universalSpawn.rotation);

                goldBallTimer = 0;
            }
        }
        if(goldNormalTimer == true)
        {
            if (goldBallTimer < 10)
            {
                goldBallTimer += Time.deltaTime;
            }
            if (goldBallTimer >= 10)
            {
                Instantiate(goldBall, universalSpawn.position, universalSpawn.rotation);

                goldBallTimer = 0;
            }
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

    public void TimerTwoSecondsButton()
    {
        twoSeconds = true;
        fourSeconds = false;
        normalTimer = false;

        timer = 0;

        ballSpawnTimerTwoSecondsButton.GetComponent<Button>().interactable = false;
        ballSpawnTimerFourSecondsButton.GetComponent<Button>().interactable = true;
        ballSpawnTimerNormalTimeButton.GetComponent<Button>().interactable = true;
    }
    public void TimerFourSecondsButton()
    {
        twoSeconds = false;
        fourSeconds = true;
        normalTimer = false;

        timer = 0;

        ballSpawnTimerTwoSecondsButton.GetComponent<Button>().interactable = true;
        ballSpawnTimerFourSecondsButton.GetComponent<Button>().interactable = false;
        ballSpawnTimerNormalTimeButton.GetComponent<Button>().interactable = true;
    }
    public void TimerNormalTimeButton()
    {
        twoSeconds = false;
        fourSeconds = false;
        normalTimer = true;

        timer = 0;

        ballSpawnTimerTwoSecondsButton.GetComponent<Button>().interactable = true;
        ballSpawnTimerFourSecondsButton.GetComponent<Button>().interactable = true;
        ballSpawnTimerNormalTimeButton.GetComponent<Button>().interactable = false;
    }



    public void GoldOneSecondTimeButton()
    {
        goldOneSecond = true;
        goldFiveSeconds = false;
        goldNormalTimer = false;

        goldBallTimer = 0;

        goldBallSpawnTimerOneSecondButton.GetComponent<Button>().interactable = false;
        goldBallSpawnTimerFiveSecondsButton.GetComponent<Button>().interactable = true;
        goldBallSpawnTimerNormalTimeButton.GetComponent<Button>().interactable = true;
    }
    public void GoldFiveSecondsTimeButton()
    {
        goldOneSecond = false;
        goldFiveSeconds = true;
        goldNormalTimer = false;

        goldBallTimer = 0;

        goldBallSpawnTimerOneSecondButton.GetComponent<Button>().interactable = true;
        goldBallSpawnTimerFiveSecondsButton.GetComponent<Button>().interactable = false;
        goldBallSpawnTimerNormalTimeButton.GetComponent<Button>().interactable = true;
    }
    public void GoldNormalTimeButton()
    {
        goldOneSecond = false;
        goldFiveSeconds = false;
        goldNormalTimer = true;

        goldBallTimer = 0;

        goldBallSpawnTimerOneSecondButton.GetComponent<Button>().interactable = true;
        goldBallSpawnTimerFiveSecondsButton.GetComponent<Button>().interactable = true;
        goldBallSpawnTimerNormalTimeButton.GetComponent<Button>().interactable = false;
    }
}
