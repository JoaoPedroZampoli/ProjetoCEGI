using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool IsConfirmMenuOpen = false;
    public GameObject PauseMenuUI;
    public GameObject ConfirmPanelUI;
    private int SceneNumber;

    // Update is called once per frame
    public void PauseGame()
    {
        Pause();
    }
    public void ResumeGame()
    {
        Resume();
    }

    public void ConfirmMenu()
    {
        OpenConfirmMenu();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void CancelQuitGame()
    {
        DoNotQuit();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsConfirmMenuOpen)
            {
                DoNotQuit();
            }
            else
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
    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    void OpenConfirmMenu()
    {
        PauseMenuUI.SetActive(false);
        ConfirmPanelUI.SetActive(true);
        IsConfirmMenuOpen = true;
    }

    void DoNotQuit()
    {
        PauseMenuUI.SetActive(true);
        ConfirmPanelUI.SetActive(false);
        IsConfirmMenuOpen = false;
    }
}
