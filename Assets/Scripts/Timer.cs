using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool timeTrigger;
    public float timer = 60;
    public Text timerText;

    public float redScoreT;
    public float blueScoreT;

    public GameObject redGoal;
    public GameObject blueGoal;
    public GameObject menuHolder;


    void Update()
    {
        if (timer > 0 && Time.timeScale > 0)
        {
            timer -= Time.deltaTime;

            timerText.text = timer.ToString("0");

        }
        if (timer <= 0 && timeTrigger == true)
        {
            redScoreT = blueGoal.GetComponent<BlueGoal>().redScore;
            blueScoreT = redGoal.GetComponent<RedGoal>().blueScore;

            timeTrigger = false;
            Game();
        }
    }


    public void Game()
    {
        Time.timeScale = 0;
        menuHolder.GetComponent<MenuController>().menuPanel.SetActive(true);

        if (redScoreT > blueScoreT)
        {
            menuHolder.GetComponent<MenuController>().redWin.SetActive(true);
        }
        if (blueScoreT > redScoreT)
        {
            menuHolder.GetComponent<MenuController>().blueWin.SetActive(true);
        }
        if (redScoreT == blueScoreT)
        {
            menuHolder.GetComponent<MenuController>().draw.SetActive(true);
        }
    }
}
