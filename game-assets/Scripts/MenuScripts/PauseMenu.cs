using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public int sceneMenuNum;
    public int sceneReloadNum;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (GameIsPaused == true)
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
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneMenuNum);
    }
    public void ReloadGame()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneReloadNum);
    }
    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();
    }
}
