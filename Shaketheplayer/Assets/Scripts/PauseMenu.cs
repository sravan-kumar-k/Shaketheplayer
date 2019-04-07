using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;

    public static bool GameIsPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
         pauseMenuUI.SetActive(true)
;        Time.timeScale = 0f;
         GameIsPaused = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("UI");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }

    public void HighScore()
    {

    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {

    }

    public void NewGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}
