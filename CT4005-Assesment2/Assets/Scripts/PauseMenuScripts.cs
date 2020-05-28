﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScripts : MonoBehaviour
{
    public static bool PausedGame = false;
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (PausedGame)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Continue ()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void Pause ()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void MenuLoad()
    {
        SceneManager.LoadScene("MenuScene");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
