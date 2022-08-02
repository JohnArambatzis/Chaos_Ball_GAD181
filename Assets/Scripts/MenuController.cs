using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public bool isPaused;

    public GameObject menuPanel;
    public GameObject controlsPanel;
    public GameObject timerHolder;

    public GameObject redWin;
    public GameObject blueWin;
    public GameObject draw;


    void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Time.timeScale > 0 && isPaused == true)
        {
            isPaused = false;
        }
        if (Time.timeScale == 0 && isPaused == false)
        {
            isPaused = true;
        }

        if (Input.GetKeyDown(KeyCode.Tab) && !isPaused)
        {
            Time.timeScale = 0;

            menuPanel.SetActive(true);
        }
    }

    public void PlayButton()
    {
        menuPanel.SetActive(false);
        redWin.SetActive(false);
        blueWin.SetActive(false);
        draw.SetActive(false);

        Time.timeScale = 1;
        timerHolder.GetComponent<Timer>().timeTrigger = true;
    }

    public void ControlsButton()
    {
        controlsPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void ControlsBackButton()
    {
        menuPanel.SetActive(true);
        controlsPanel.SetActive(false);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}