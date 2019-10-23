﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadStart()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
