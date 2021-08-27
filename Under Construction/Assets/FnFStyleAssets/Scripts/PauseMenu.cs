using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static bool isGamePaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        void ResumeGame()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            isGamePaused = false;
        }
        void PauseGame()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            isGamePaused = true;
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu Demo");
    }
}
